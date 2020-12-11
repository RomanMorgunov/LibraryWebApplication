using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowLibraryWebApplication
{
    [Binding]
    public sealed class LoginToLibrary
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private string _loginPage;

        public LoginToLibrary(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = new ChromeDriver();
        }

        [Given(@"login page ""(.*)""")]
        public void GivenLoginPage(string p0)
        {
            _loginPage = p0;
        }

        [When(@"I open login page")]
        public void WhenIOpenLoginPage()
        {
            _driver.Navigate().GoToUrl(_loginPage);
        }

        [When(@"I enter ""(.*)"" in element with id ""(.*)""")]
        public void WhenIEnterInElementWithId(string email, string emailId)
        {
            _driver.FindElement(By.Id(emailId)).SendKeys(email);
        }

        [When(@"I press element with id ""(.*)""")]
        public void WhenIPressElementWithId(string loginButtonId)
        {
            _driver.FindElement(By.Id(loginButtonId)).Click();
        }

        [When(@"I go to the page ""(.*)"" page")]
        public void WhenIHaveToGoToThePagePage(string p0)
        {
            _driver.Navigate().GoToUrl(p0);
        }
        
        [Then(@"i have to go to the page ""(.*)"" page")]
        public void ThenIHaveToGoToThePagePage(string p0)
        {
            Assert.IsTrue(_driver.Url.Contains(p0));
            _driver.Quit();
        }
    }
}