﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.296
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create generic dynamic sets objects from SpecFlow table")]
    public partial class CreateGenericDynamicSetsObjectsFromSpecFlowTableFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GenericDynamicSetFromTable.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create generic dynamic sets objects from SpecFlow table", "In order to have more control of value types\r\nAs a user of SpecFlow Dynamic\r\nI wa" +
                    "nt to use generics to specify the type for the created set of dynamic objects fr" +
                    "om a table", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create set of dynamic objects with all properties able to cast to string and bool" +
            "")]
        [NUnit.Framework.TestCaseAttribute("string", new string[0])]
        [NUnit.Framework.TestCaseAttribute("bool", new string[0])]
        public virtual void CreateSetOfDynamicObjectsWithAllPropertiesAbleToCastToStringAndBool(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create set of dynamic objects with all properties able to cast to string and bool" +
                    "", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property1",
                        "Property2",
                        "Property3",
                        "Property4"});
            table1.AddRow(new string[] {
                        "true",
                        "false",
                        "true",
                        "false"});
            table1.AddRow(new string[] {
                        "false",
                        "true",
                        "false",
                        "true"});
            table1.AddRow(new string[] {
                        "true",
                        "false",
                        "true",
                        "false"});
            table1.AddRow(new string[] {
                        "false",
                        "true",
                        "false",
                        "true"});
#line 7
 testRunner.When(string.Format("I create a set of dynamic instances from this table of type \'{0}\'", type), ((string)(null)), table1);
#line 13
 testRunner.Then("I should have a list of 4 dynamic objects");
#line 14
 testRunner.And(string.Format("each item should be of type \'{0}\'", type));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create set of dynamic objects with all properties able to cast to string, int, an" +
            "d double")]
        [NUnit.Framework.TestCaseAttribute("string", new string[0])]
        [NUnit.Framework.TestCaseAttribute("int", new string[0])]
        [NUnit.Framework.TestCaseAttribute("double", new string[0])]
        public virtual void CreateSetOfDynamicObjectsWithAllPropertiesAbleToCastToStringIntAndDouble(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create set of dynamic objects with all properties able to cast to string, int, an" +
                    "d double", exampleTags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property1",
                        "Property2",
                        "Property3",
                        "Property4"});
            table2.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table2.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table2.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table2.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
#line 25
 testRunner.When(string.Format("I create a set of dynamic instances from this table of type \'{0}\'", type), ((string)(null)), table2);
#line 31
 testRunner.Then("I should have a list of 4 dynamic objects");
#line 32
 testRunner.And(string.Format("each item should be of type \'{0}\'", type));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create set of dynamic objects with all properties able to cast to string and Date" +
            "Time")]
        [NUnit.Framework.TestCaseAttribute("string", new string[0])]
        [NUnit.Framework.TestCaseAttribute("DateTime", new string[0])]
        public virtual void CreateSetOfDynamicObjectsWithAllPropertiesAbleToCastToStringAndDateTime(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create set of dynamic objects with all properties able to cast to string and Date" +
                    "Time", exampleTags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property1",
                        "Property2",
                        "Property3",
                        "Property4"});
            table3.AddRow(new string[] {
                        "1901-05-31",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03:05",
                        "1901-05-31 10:03:06.231"});
            table3.AddRow(new string[] {
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03"});
            table3.AddRow(new string[] {
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03"});
            table3.AddRow(new string[] {
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03",
                        "1901-05-31 10:03"});
#line 43
 testRunner.When(string.Format("I create a set of dynamic instances from this table of type \'{0}\'", type), ((string)(null)), table3);
#line 49
 testRunner.Then("I should have a list of 4 dynamic objects");
#line 50
 testRunner.And(string.Format("each item should be of type \'{0}\'", type));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create set of dynamic objects with no properties able to cast to DateTime")]
        [NUnit.Framework.TestCaseAttribute("DateTime", new string[0])]
        public virtual void CreateSetOfDynamicObjectsWithNoPropertiesAbleToCastToDateTime(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create set of dynamic objects with no properties able to cast to DateTime", exampleTags);
#line 60
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property1",
                        "Property2",
                        "Property3",
                        "Property4"});
            table4.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table4.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table4.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
            table4.AddRow(new string[] {
                        "0",
                        "1",
                        "0",
                        "1"});
#line 61
 testRunner.When(string.Format("I create a set of dynamic instances from this table of type \'{0}\'", type), ((string)(null)), table4);
#line 67
 testRunner.Then("I should have a list of 4 dynamic objects");
#line 68
 testRunner.And("each item should be of type \'string\'");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
