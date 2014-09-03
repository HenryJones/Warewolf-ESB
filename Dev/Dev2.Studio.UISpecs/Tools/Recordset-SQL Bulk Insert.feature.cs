﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Studio.UI.Specs.Tools
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute()]
    public partial class Recordset_SQLBulkInsertFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Recordset-SQL Bulk Insert.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Recordset-SQL Bulk Insert", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Recordset-SQL Bulk Insert")))
            {
                Dev2.Studio.UI.Specs.Tools.Recordset_SQLBulkInsertFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Correcting errors on sql bulk insert clicking Done shows small view (using ids)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Recordset-SQL Bulk Insert")]
        public virtual void CorrectingErrorsOnSqlBulkInsertClickingDoneShowsSmallViewUsingIds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Correcting errors on sql bulk insert clicking Done shows small view (using ids)", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have Warewolf running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("all tabs are closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I click \"RIBBONNEWENDPOINT\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("I send \"Sql Bulk Insert\" to \"TOOLBOX,PART_SearchBox\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("I drag \"TOOLBOX,PART_Tools,Recordset,Dev2.Activities.DsfSqlBulkInsertActivity\" on" +
                    "to \"WORKSURFACE,StartSymbol\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Given("I double click \"WORKFLOWDESIGNER,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(Sql" +
                    "BulkInsertDesigner)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("I click \"WORKFLOWDESIGNER,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(SqlBulkIns" +
                    "ertDesigner),DoneButton\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Given("I click point \"151,42\" on \"UI_DocManager_AutoID,UI_SplitPane_AutoID,UI_TabManager" +
                    "_AutoID,UI_WorkflowDesigner_AutoID,UserControl_1,scrollViewer,ActivityTypeDesign" +
                    "er,WorkflowItemPresenter,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(SqlBulkIns" +
                    "ertDesigner)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("I send \"GetCities{ENTER}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Given("I click point \"148,75\" on \"UI_DocManager_AutoID,UI_SplitPane_AutoID,UI_TabManager" +
                    "_AutoID,UI_WorkflowDesigner_AutoID,UserControl_1,scrollViewer,ActivityTypeDesign" +
                    "er,WorkflowItemPresenter,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(SqlBulkIns" +
                    "ertDesigner)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I send \"dbo.City{ENTER}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I click \"WORKFLOWDESIGNER,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(SqlBulkIns" +
                    "ertDesigner),DoneButton\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Given(@"""UI_DocManager_AutoID,UI_SplitPane_AutoID,UI_TabManager_AutoID,UI_WorkflowDesigner_AutoID,UserControl_1,scrollViewer,ActivityTypeDesigner,WorkflowItemPresenter,Unsaved 1(FlowchartDesigner),SQL Bulk Insert(SqlBulkInsertDesigner),SmallViewContent,UI__Database_AutoID"" is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
