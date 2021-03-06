﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Utility.WebRequest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WebRequestFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WebRequest.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WebRequest", "In order to download html content\r\nAs a Warewolf user\r\nI want a tool that I can i" +
                    "nput a url and get a html document", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "WebRequest")))
            {
                Dev2.Activities.Specs.Toolbox.Utility.WebRequest.WebRequestFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLToDownloadHtml()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL to download html", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have the url \"http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?html\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the result should contain the string \"Welcome to ASP.NET Web API\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table1.AddRow(new string[] {
                        "http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?html",
                        ""});
#line 12
 testRunner.And("the debug inputs as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2.AddRow(new string[] {
                        "[[result]] = String"});
#line 15
 testRunner.And("the debug output as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecified(string url, string timeoutSeconds, string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL to download html with timeout specified", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given(string.Format("I have the url \'{0}\' with timeoutSeconds \'{1}\'", url, timeoutSeconds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then(string.Format("the result should contain the string \"{0}\"", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header",
                        "Time Out Seconds"});
            table3.AddRow(new string[] {
                        string.Format("{0}", url),
                        "",
                        string.Format("{0}", timeoutSeconds)});
#line 24
 testRunner.And("the debug inputs as", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table4.AddRow(new string[] {
                        "[[result]] = String"});
#line 27
 testRunner.And("the debug output as", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html with timeout specified")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:url", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=15")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:timeoutSeconds", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "Wait Successful")]
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecified_Variant0()
        {
            this.EnterAURLToDownloadHtmlWithTimeoutSpecified("http://tst-ci-remote:3142/Public/Wait?WaitSeconds=15", "20", "Wait Successful", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html with timeout specified")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:url", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=110")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:timeoutSeconds", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "Wait Successful")]
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecified_Variant1()
        {
            this.EnterAURLToDownloadHtmlWithTimeoutSpecified("http://tst-ci-remote:3142/Public/Wait?WaitSeconds=110", "120", "Wait Successful", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html with timeout specified")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:url", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=110")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:timeoutSeconds", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "Wait Successful")]
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecified_Variant2()
        {
            this.EnterAURLToDownloadHtmlWithTimeoutSpecified("http://tst-ci-remote:3142/Public/Wait?WaitSeconds=110", "0", "Wait Successful", ((string[])(null)));
        }
        
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecifiedTooShort(string url, string timeoutSeconds, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL to download html with timeout specified too short", exampleTags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given(string.Format("I have the url \'{0}\' with timeoutSeconds \'{1}\'", url, timeoutSeconds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header",
                        "Time Out Seconds"});
            table5.AddRow(new string[] {
                        string.Format("{0}", url),
                        "",
                        string.Format("{0}", timeoutSeconds)});
#line 40
 testRunner.And("the debug inputs as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table6.AddRow(new string[] {
                        "[[result]] = String"});
#line 43
 testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html with timeout specified too short")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=150")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:url", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=150")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:timeoutSeconds", "10")]
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecifiedTooShort_HttpTst_Ci_Remote3142PublicWaitWaitSeconds150()
        {
            this.EnterAURLToDownloadHtmlWithTimeoutSpecifiedTooShort("http://tst-ci-remote:3142/Public/Wait?WaitSeconds=150", "10", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL to download html with timeout specified too short")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=15")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:url", "http://tst-ci-remote:3142/Public/Wait?WaitSeconds=15")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:timeoutSeconds", "10")]
        public virtual void EnterAURLToDownloadHtmlWithTimeoutSpecifiedTooShort_HttpTst_Ci_Remote3142PublicWaitWaitSeconds15()
        {
            this.EnterAURLToDownloadHtmlWithTimeoutSpecifiedTooShort("http://tst-ci-remote:3142/Public/Wait?WaitSeconds=15", "10", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a badly formed URL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterABadlyFormedURL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a badly formed URL", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("I have the url \"www.google.comx\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("the result should contain the string \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table7.AddRow(new string[] {
                        "www.google.comx",
                        ""});
#line 56
 testRunner.And("the debug inputs as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table8.AddRow(new string[] {
                        "[[result]] ="});
#line 59
 testRunner.And("the debug output as", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL made up of text and variables with no header")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLMadeUpOfTextAndVariablesWithNoHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL made up of text and variables with no header", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
    testRunner.Given("I have the url \"http://[[site]][[file]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("I have a web request variable \"[[site]]\" equal to \"rsaklfsvrtfsbld/IntegrationTes" +
                    "tSite/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I have a web request variable \"[[file]]\" equal to \"Proxy.ashx?html\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("the result should contain the string \"Welcome to ASP.NET Web API\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table9.AddRow(new string[] {
                        "http://[[site]][[file]] = http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?h" +
                            "tml",
                        ""});
#line 70
 testRunner.And("the debug inputs as", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table10.AddRow(new string[] {
                        "[[result]] = String"});
#line 73
 testRunner.And("the debug output as", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL and 2 variables each with a header parameter (json)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLAnd2VariablesEachWithAHeaderParameterJson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL and 2 variables each with a header parameter (json)", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I have the url \"http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.And("I have a web request variable \"[[ContentType]]\" equal to \"Content-Type\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("I have a web request variable \"[[Type]]\" equal to \"application/json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("I have the Header \"[[ContentType]]: [[Type]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("the result should contain the string \"[\"value1\",\"value2\"]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table11.AddRow(new string[] {
                        "http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx",
                        "[[ContentType]]: [[Type]] = Content-Type: application/json\""});
#line 86
 testRunner.And("the debug inputs as", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table12.AddRow(new string[] {
                        "[[result]] = [\"value1\",\"value2\"]"});
#line 89
 testRunner.And("the debug output as", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL and 2 variables each with a header parameter (xml)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLAnd2VariablesEachWithAHeaderParameterXml()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL and 2 variables each with a header parameter (xml)", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line 94
 testRunner.Given("I have the url \"http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
 testRunner.And("I have a web request variable \"[[ContentType]]\" equal to \"Content-Type\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("I have a web request variable \"[[Type]]\" equal to \"application/xml\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I have the Header \"[[ContentType]]: [[Type]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("the result should contain the string \"<string>value1</string>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table13.AddRow(new string[] {
                        "http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx",
                        "[[ContentType]]: [[Type]] = Content-Type: application/xml\""});
#line 101
 testRunner.And("the debug inputs as", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table14.AddRow(new string[] {
                        "[[result]] = <string>value1</string>"});
#line 104
 testRunner.And("the debug output as", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL that returns json")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLThatReturnsJson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL that returns json", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 109
 testRunner.Given("I have the url \"http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("the result should contain the string \"[\"value1\",\"value2\"]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table15.AddRow(new string[] {
                        "http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?json",
                        ""});
#line 113
 testRunner.And("the debug inputs as", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table16.AddRow(new string[] {
                        "[[result]] = [\"value1\",\"value2\"]"});
#line 116
 testRunner.And("the debug output as", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL that returns xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLThatReturnsXml()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL that returns xml", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line 121
 testRunner.Given("I have the url \"http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?xml\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then("the result should contain the string \"<string>value1</string>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table17.AddRow(new string[] {
                        "http://rsaklfsvrtfsbld/IntegrationTestSite/Proxy.ashx?xml",
                        ""});
#line 125
 testRunner.And("the debug inputs as", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table18.AddRow(new string[] {
                        "[[result]] = <string>value1</string>"});
#line 128
 testRunner.And("the debug output as", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a blank URL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterABlankURL()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a blank URL", ((string[])(null)));
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
 testRunner.Given("I have the url \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("the result should contain the string \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table19.AddRow(new string[] {
                        "\"\"",
                        ""});
#line 137
 testRunner.And("the debug inputs as", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table20.AddRow(new string[] {
                        "[[result]] ="});
#line 140
 testRunner.And("the debug output as", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Enter a URL that is a negative index recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebRequest")]
        public virtual void EnterAURLThatIsANegativeIndexRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter a URL that is a negative index recordset", ((string[])(null)));
#line 144
this.ScenarioSetup(scenarioInfo);
#line 145
 testRunner.Given("I have the url \"[[rec(-1).set]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
 testRunner.When("the web request tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then("the result should contain the string \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL",
                        "Header"});
            table21.AddRow(new string[] {
                        "[[rec(-1).set]] =",
                        ""});
#line 149
 testRunner.And("the debug inputs as", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table22.AddRow(new string[] {
                        "[[result]] ="});
#line 152
 testRunner.And("the debug output as", ((string)(null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
