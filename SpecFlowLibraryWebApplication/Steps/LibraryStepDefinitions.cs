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
        
        private readonly ScenarioContext _scenarioContext;

        private ChromeDriver SeleiumDriver => ((ChromeDriver)_scenarioContext["ChromeDriver"]);

        private static string GetFullUrl(string urlPart)
        {
            return UrlBase + urlPart;
        }

        public LibraryStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
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

        [When(@"I am on the page ""(.*)""")]
        public void WhenIAmOnPage(string urlPart)
        {
            ChromeDriver driver = SeleiumDriver;
            string expected = GetFullUrl(urlPart);

            Assert.AreEqual(expected, driver.Url);
        }

        [When(@"I am waiting for ""(.*)"" milliseconds")]
        public void WhenIAmWaitingForMilliseconds(int millisecondsTimeout)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout);
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
        public void ThenIFindBookWithName(string bookName)
        {
            ChromeDriver driver = SeleiumDriver;

            var actual = driver.FindElementsByLinkText(bookName);

            CollectionAssert.IsNotEmpty(actual);
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
    }
}