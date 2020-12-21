using System;
using System.Linq;
using System.IO;
using System.Diagnostics;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LibraryWebApplicationUI.Data;

namespace SpecFlowLibraryWebApplication
{
    [Binding]
    public sealed class LibraryStepDefinitions
    {
        private const string UrlBase = "https://localhost:5001/";
        private const string ValueAttributeInInput = "value";
        
        private readonly ScenarioContext _scenarioContext;

        private ChromeDriver SeleiumDriver => ((ChromeDriver)_scenarioContext["ChromeDriver"]);

        private static string GetFullUrl(string urlPart)
        {
            return UrlBase + urlPart;
        }

        public LibraryStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //_scenarioContext["ChromeDriver"] = new ChromeDriver(options);
            _scenarioContext["ChromeDriver"] = new ChromeDriver();
        }

        [AfterScenario]
        private void DisposeSeleniumDriver()
        {
            ChromeDriver driver = SeleiumDriver;
            driver.Quit();
        }

        [When(@"I open page ""(.*)""")]
        public void WhenIOpenPage(string page)
        {
            ChromeDriver driver = SeleiumDriver;

            driver.Navigate().GoToUrl(GetFullUrl(page));
        }

        [When(@"I enter ""(.*)"" in element with id ""(.*)""")]
        public void WhenIEnterInElementWithId(string text, string elementId)
        {
            ChromeDriver driver = SeleiumDriver;

            var element = driver.FindElementById(elementId);
            element.Clear();
            element.SendKeys(text);
        }

        [When(@"I press element with id ""(.*)""")]
        public void WhenIPressElementWithId(string elementId)
        {
            ChromeDriver driver = SeleiumDriver;

            driver.FindElementById(elementId).Click();
        }
        
        [When(@"I am submitting a form with id ""(.*)""")]
        public void WhenISubmitThisFormWithId(string elementId)
        {
            ChromeDriver driver = SeleiumDriver;

            driver.FindElementById(elementId).Submit();
        }

        [When(@"I press element with name ""(.*)""")]
        public void WhenIPressElementWithName(string elementName)
        {
            ChromeDriver driver = SeleiumDriver;

            driver.FindElementByLinkText(elementName).Click();
        }

        [When(@"I press element with class ""(.*)""")]
        public void WhenIPressElementWithClass(string elementClass)
        {
            ChromeDriver driver = SeleiumDriver;

            driver.FindElementByClassName(elementClass).Click();
        }

        [When(@"I am waiting for ""(.*)"" milliseconds")]
        public void WhenIAmWaitingForMilliseconds(int millisecondsTimeout)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout);
        }

        [When(@"I click on the button the adjacent column of the element name ""(.*)""")]
        public void WhenIClickOnTheButtonWithTheTextTheAdjacentColumnOfTheItem(string elementName)
        {
            const string TableRowTag = "tr";
            const string TableDataTag = "td";
            const string FormTag = "form";
            const string ButtonTag = "button";

            ChromeDriver driver = SeleiumDriver;

            var rows = driver.FindElementsByTagName(TableRowTag);
            var soughtRow = (from row in rows
                             where row.FindElement(By.TagName(TableDataTag)).Text == elementName
                             select row).First();
            var button = soughtRow.FindElement(By.TagName(FormTag)).FindElement(By.TagName(ButtonTag));

            button.Click();
        }

        [When(@"I click on the link the adjacent column of the element name ""(.*)""")]
        public void WhenIClickOnTheLinkWithTheTextTheAdjacentColumnOfTheElementName(string elementName)
        {
            const string TableRowTag = "tr";
            const string TableDataTag = "td";
            const string LinkTag = "a";

            ChromeDriver driver = SeleiumDriver;

            var rows = driver.FindElementsByTagName(TableRowTag);
            var soughtRow = (from row in rows
                             where row.FindElement(By.TagName(TableDataTag)).Text == elementName
                             select row).First();
            var link = soughtRow.FindElement(By.TagName(LinkTag));

            link.Click();
        }

        [When(@"I check the checkbox with the class ""(.*)"" and the name ""(.*)""")]
        public void WhenICheckTheBoxWithTheClassAndTheName(string className, string checkboxText)
        {
            ChromeDriver driver = SeleiumDriver;

            var checkboxes = driver.FindElementsByClassName(className);
            for (int i = 0; i < checkboxes.Count; i++)
            {
                string s = checkboxes[i].Text;
            }

            var adminCheckbox = checkboxes.Where(e => e.GetAttribute(ValueAttributeInInput) == checkboxText).First();
            if (!adminCheckbox.Selected)
            {
                adminCheckbox.Click();
            }
        }

        [Then(@"I am on the page ""(.*)""")]
        public void WhenIAmOnPage(string urlPart)
        {
            ChromeDriver driver = SeleiumDriver;
            string expected = GetFullUrl(urlPart);

            Assert.AreEqual(expected, driver.Url);
        }

        [Then(@"I am not on the page ""(.*)""")]
        public void ThenIAmNotOnThePage(string urlPart)
        {
            ChromeDriver driver = SeleiumDriver;
            string expected = GetFullUrl(urlPart);

            Assert.AreNotEqual(expected, driver.Url);
        }

        [Then(@"element with id ""(.*)"" has text ""(.*)""")]
        public void ThenElementWithIdHasText(string elementId, string expected)
        {
            ChromeDriver driver = SeleiumDriver;

            string actual = driver.FindElementById(elementId).Text;

            Assert.AreEqual(expected, actual);
        }

        [Then(@"element with id ""(.*)"" exists")]
        public void ThenElementWithIdExists(string elementId)
        {
            ChromeDriver driver = SeleiumDriver;

            var actual = driver.FindElementById(elementId);

            Assert.IsNotNull(actual);
        }

        [Then(@"I find book with name ""(.*)""")]
        public void ThenIFindBookWithName(string elementName)
        {
            ChromeDriver driver = SeleiumDriver;

            var actual = driver.FindElementsByLinkText(elementName);

            CollectionAssert.IsNotEmpty(actual);
        }

        [Then(@"I find book with tag ""(.*)"" and name ""(.*)""")]
        public void ThenIFindBookWithTagAndName(string tag, string elementName)
        {
            ChromeDriver driver = SeleiumDriver;

            var elements = driver.FindElementsByTagName(tag);
            var actual = (from e in elements
                          select e.Text);

            CollectionAssert.Contains(actual, elementName);
        }

        [Then(@"I can not find book with tag ""(.*)"" and name ""(.*)""")]
        public void ThenICanNotFindBookWithTagAndName(string tag, string elementName)
        {
            ChromeDriver driver = SeleiumDriver;

            var elements = driver.FindElementsByTagName(tag);
            var actual = (from e in elements
                          select e.Text);

            CollectionAssert.DoesNotContain(actual, elementName);
        }

        [Then(@"I can not find book with name ""(.*)""")]
        public void ThenICanNotFindBookWithName(string bookName)
        {
            ChromeDriver driver = SeleiumDriver;

            var actual = driver.FindElementsByLinkText(bookName);

            CollectionAssert.IsEmpty(actual);
        }

        [Then(@"element with id ""(.*)"" does not exist")]
        public void ThenElementWithIdDoesNotExist(string elementId)
        {
            ChromeDriver driver = SeleiumDriver;

            void TryFindElement()
            {
                var actual = driver.FindElementById(elementId);
            }

            Assert.Throws<NoSuchElementException>(TryFindElement);
        }

        [Then(@"I validate that the checkbox with the class ""(.*)"" has role ""(.*)""")]
        public void ThenIValidateThatTheCheckboxWithTheClassHasRole(string className, string checkboxText)
        {
            ChromeDriver driver = SeleiumDriver;

            var checkboxes = driver.FindElementsByClassName(className);
            var adminCheckbox = checkboxes.Where(e => e.GetAttribute(ValueAttributeInInput) == checkboxText).First();

            Assert.IsTrue(adminCheckbox.Selected);
        }
    }
}