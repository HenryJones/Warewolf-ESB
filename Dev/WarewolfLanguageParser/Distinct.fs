﻿module Distinct

open LanguageAST
//open LanguageEval
open Microsoft.FSharp.Text.Lexing
open DataASTMutable
open WarewolfParserInterop
open WarewolfDataEvaluationCommon
open Where
open Microsoft.FSharp.Linq
let DistinctIndexes (recset:WarewolfRecordset) (columnName:string) =
    let positions = Seq.zip [0..recset.Data.[PositionColumn].Count] recset.Data.[columnName] 
    Seq.distinctBy (fun (a,b) -> b.GetHashCode()) positions |> Seq.map fst
 
let DistinctValues (recset:WarewolfRecordset) (columnName:string) (positions:int seq)= 
    Seq.map (fun a -> recset.Data.[columnName].[a].ToString()) positions


let AssignFromList (oldenv:WarewolfEnvironment) (datas:string seq) (exp:string) (startPositions:Map<string,int>) =
    let parsed = WarewolfDataEvaluationCommon.ParseLanguageExpression exp
    let data = List.ofSeq datas
    let mutable env = oldenv
    match parsed with 
        | LanguageExpression.WarewolfAtomAtomExpression a -> env
        | LanguageExpression.ComplexExpression b -> failwith "this method is not intended for use with complex expressions"
        | ScalarExpression b -> AssignEvaluation.EvalAssign exp (System.String.Join("," ,data)) env
        | RecordSetExpression recset -> match recset.Index with
                                            | IntIndex int -> if int<0 then failwith "invalid negative index" else  AssignEvaluation.EvalAssign exp (Seq.last data) env
                                            | Last -> let start = match Map.tryFind recset.Name startPositions with
                                                                    | Some a -> a
                                                                    | None -> 0
                                                      for i in [0.. (Seq.length data)-1] do
                                                         env<-  AssignEvaluation.EvalAssign (sprintf "[[%s(%i).%s]]" recset.Name  (1+i+start) recset.Column) data.[i]  env
                                                      env
                                            | Star -> for i in [0.. (Seq.length data)-1] do
                                                         env<-  AssignEvaluation.EvalAssign (sprintf "[[%s(%i).%s]]" recset.Name  (1+i) recset.Column) data.[i]  env
                                                      env

                                            | IndexExpression indexp ->  match indexp with 
                                                                            |  WarewolfAtomAtomExpression atom -> let inval = AtomToInt atom

                                                                                                                  if inval<0 then failwith "invalid negative index" else AssignEvaluation.EvalAssign exp (Seq.last data) env
                                                                            | _ -> failwith "this method is not intended for use with complex expressions"
        | _ -> failwith "only recsets and scalars allowed" 

let EvalDistinct (env:WarewolfEnvironment) (cols:string seq) (distictcols:string seq) (result:string seq )  = 
    let EvalDistinctInner (recset: RecordSetIdentifier) =
         DistinctIndexes env.RecordSets.[recset.Name] recset.Column  
    let ToRecset (exp: LanguageExpression) =
        match exp with 
        |   RecordSetExpression recset ->  recset
        |_ -> failwith "scalar in unique"
    let IsRecset (exp: LanguageExpression) =
        match exp with 
        |   RecordSetExpression recset ->  true
        |_ -> false
    let EvalDistinctValuesFromExp  (indexes: int seq)  (recset: RecordSetIdentifier) =
         DistinctValues env.RecordSets.[recset.Name] recset.Column indexes      
    let inter = Seq.map (EvalToExpression env) cols |> Seq.map ParseLanguageExpression |> Seq.map ToRecset
    let resultsIds = Map.map (fun (a:string) (b:WarewolfRecordset) -> b.Count:int) env.RecordSets

    if 1= (Seq.distinctBy (fun (a:RecordSetIdentifier) -> a.Name.GetHashCode()) inter |> Seq.length) then
        let cols = inter|> Seq.collect EvalDistinctInner |> Seq.distinct   
        let values = Seq.map (EvalToExpression env) distictcols  |> Seq.map ParseLanguageExpression  |> Seq.map ToRecset |>   Seq.map (EvalDistinctValuesFromExp cols) |> Seq.zip  result
        let mutable foldingenv = env
        for (a,b) in values do
          foldingenv<- AssignFromList foldingenv b a resultsIds
        foldingenv
    else
        failwith "multiple recordsets detected"