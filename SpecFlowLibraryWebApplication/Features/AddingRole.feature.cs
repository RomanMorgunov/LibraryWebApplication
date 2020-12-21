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
    [NUnit.Framework.DescriptionAttribute("AddingRole")]
    public partial class AddingRoleFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AddingRole.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AddingRole", "    I want to test adding a role.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
    testRunner.When("I open page \"Identity/Account/Login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Unsuccessful check adding a role as anonymous")]
        [NUnit.Framework.CategoryAttribute("fail")]
        [NUnit.Framework.CategoryAttribute("anonymous")]
        public virtual void UnsuccessfulCheckAddingARoleAsAnonymous()
        {
            string[] tagsOfScenario = new string[] {
                    "fail",
                    "anonymous"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unsuccessful check adding a role as anonymous", null, tagsOfScenario, argumentsOfScenario);
#line 9
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
#line 4
this.FeatureBackground();
#line hidden
#line 10
    testRunner.When("I open page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then("I am not on the page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Unsuccessful check adding a role as user")]
        [NUnit.Framework.CategoryAttribute("fail")]
        [NUnit.Framework.CategoryAttribute("user")]
        public virtual void UnsuccessfulCheckAddingARoleAsUser()
        {
            string[] tagsOfScenario = new string[] {
                    "fail",
                    "user"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unsuccessful check adding a role as user", null, tagsOfScenario, argumentsOfScenario);
#line 15
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
#line 4
this.FeatureBackground();
#line hidden
#line 16
    testRunner.When("I enter \"vip.roman99@mail.ru\" in element with id \"email\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
    testRunner.And("I enter \"r47qkuDLJFx7F5U!\" in element with id \"password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 18
    testRunner.And("I press element with id \"login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
    testRunner.When("I open page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
    testRunner.Then("I am not on the page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful check adding a role as administrator")]
        [NUnit.Framework.CategoryAttribute("success")]
        [NUnit.Framework.CategoryAttribute("admin")]
        public virtual void SuccessfulCheckAddingARoleAsAdministrator()
        {
            string[] tagsOfScenario = new string[] {
                    "success",
                    "admin"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful check adding a role as administrator", null, tagsOfScenario, argumentsOfScenario);
#line 24
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
#line 4
this.FeatureBackground();
#line hidden
#line 25
    testRunner.When("I enter \"rom4ik9994@gmail.com\" in element with id \"email\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
    testRunner.And("I enter \"HKs498R8tpqKvBK!!\" in element with id \"password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 27
    testRunner.And("I press element with id \"login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 28
    testRunner.When("I open page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
    testRunner.Then("I am on the page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
    testRunner.When("I enter \"test role\" in element with id \"role-name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
    testRunner.And("I am submitting a form with id \"create-role-form\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 32
    testRunner.And("I open page \"Roles\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 33
    testRunner.Then("I find book with tag \"td\" and name \"test role\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error when adding without role name")]
        [NUnit.Framework.CategoryAttribute("fail")]
        [NUnit.Framework.CategoryAttribute("admin")]
        public virtual void ErrorWhenAddingWithoutRoleName()
        {
            string[] tagsOfScenario = new string[] {
                    "fail",
                    "admin"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error when adding without role name", null, tagsOfScenario, argumentsOfScenario);
#line 37
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
#line 4
this.FeatureBackground();
#line hidden
#line 38
    testRunner.When("I enter \"rom4ik9994@gmail.com\" in element with id \"email\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
    testRunner.And("I enter \"HKs498R8tpqKvBK!!\" in element with id \"password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 40
    testRunner.And("I press element with id \"login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 41
    testRunner.When("I open page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
    testRunner.Then("I am on the page \"Roles/CreateRole\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
    testRunner.When("I enter \"\" in element with id \"role-name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.And("I am submitting a form with id \"create-role-form\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 45
    testRunner.Then("element with id \"validation-summary\" has text \"Поле Новая роль является обязатель" +
                        "ным.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
