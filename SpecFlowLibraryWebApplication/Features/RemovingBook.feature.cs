﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowLibraryWebApplication.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RemovingBook")]
    public partial class RemovingBookFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "RemovingBook.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "RemovingBook", "    I want to test removing a book.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful check editing a book as administrator")]
        [NUnit.Framework.CategoryAttribute("success")]
        [NUnit.Framework.CategoryAttribute("admin")]
        public virtual void SuccessfulCheckEditingABookAsAdministrator()
        {
            string[] tagsOfScenario = new string[] {
                    "success",
                    "admin"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful check editing a book as administrator", null, tagsOfScenario, argumentsOfScenario);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.When("I open page \"Identity/Account/Login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
    testRunner.And("I enter \"rom4ik9994@gmail.com\" in element with id \"email\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
    testRunner.And("I enter \"HKs498R8tpqKvBK!!\" in element with id \"password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
    testRunner.And("I press element with id \"login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
    testRunner.When("I open page \"Home/Index\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
    testRunner.And("I press element with name \"book-name changed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 13
    testRunner.And("I am waiting for \"500\" milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 14
    testRunner.And("I press element with id \"delete-book\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 15
    testRunner.And("I open page \"Home/Index\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 16
    testRunner.Then("I cannot find book with name \"book-name changed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
