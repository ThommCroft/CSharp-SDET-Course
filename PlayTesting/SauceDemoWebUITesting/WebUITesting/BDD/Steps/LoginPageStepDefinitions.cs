using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebUITesting.Configuration;
using WebUITesting.Lib;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    public class LoginPageStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website = new SD_Website<ChromeDriver>();

        [Given(@"I am on the Login Page")]
        public void GivenIAmOnTheLoginPage()
        {
            SD_Website.LoginPage.VisitLoginPage();
        }

        [When(@"I enter a valid username and password")]
        public void WhenIEnterAValidUsernameAndPassword()
        {
            SD_Website.LoginPage.InputUsername("standard_user");
            SD_Website.LoginPage.InputPassword("secret_sauce");
            SD_Website.LoginPage.ClickLoginButton();
        }

        [Then(@"I am taken to the store inventory page")]
        public void ThenIAmTakenToTheStoreInventoryPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.inventoryUrl));
        }

        [When(@"I attempt to enter my username and password")]
        public void WhenIAttemptToEnterMyUsernameAndPassword()
        {
            SD_Website.LoginPage.InputUsername("locked_out_user");
            SD_Website.LoginPage.InputPassword("secret_sauce");
            SD_Website.LoginPage.ClickLoginButton();
        }

        [When(@"I attempt to enter my ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIAttemptToEnterMyAnd(string username, string password)
        {
            SD_Website.LoginPage.InputUsername(username);
            SD_Website.LoginPage.InputPassword(password);
            SD_Website.LoginPage.ClickLoginButton();
        }


        [Then(@"I recieve an error message ""([^""]*)""")]
        public void ThenIRecieveAnErrorMessage(string errorMessage)
        {
            Assert.That(SD_Website.LoginPage.GetErrorMessage(), Is.EqualTo(errorMessage));
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}
