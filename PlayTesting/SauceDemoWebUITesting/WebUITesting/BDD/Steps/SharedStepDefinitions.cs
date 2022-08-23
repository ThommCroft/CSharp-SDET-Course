using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebUITesting.Lib;

namespace WebUITesting.BDD.Steps
{
    public class SharedStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website = new SD_Website<ChromeDriver>();

        [Given(@"I am Logged in")]
        public void GivenIAmLoggedIn()
        {
            SD_Website.LoginPage.VisitLoginPage();
            SD_Website.LoginPage.InputUsername("standard_user");
            SD_Website.LoginPage.InputPassword("secret_sauce");
            SD_Website.LoginPage.ClickLoginButton();
        }

        [Given(@"I am on the burger menu")]
        public void GivenIAmOnTheBurgerMenu()
        {
            SD_Website.InventoryPage.ClickBurgerMenuButton();
            Thread.Sleep(1000);
        }

        [When(@"I click the about button")]
        public void WhenIClickTheAboutButton()
        {
            SD_Website.InventoryPage.ClickAboutButton();
        }

        [Then(@"I am taken to saucelabs website")]
        public void ThenIAmTakenToSaucelabsWebsite()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetSauceLabsUrl()));
        }

        [When(@"I click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            SD_Website.InventoryPage.ClickLogOutButton();
        }

        [Then(@"I am taken to the login page")]
        public void ThenIAmTakenToTheLoginPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetLoginPageUrl()));
        }

        [When(@"I click the all items button")]
        public void WhenIClickTheAllItemsButton()
        {
            SD_Website.InventoryPage.ClickAllItemsButton();
            Thread.Sleep(1000);
        }

        [When(@"I click the red cross button")]
        public void WhenIClickTheRedCrossButton()
        {
            SD_Website.InventoryPage.ClickBurgerRedCrossButton();
            Thread.Sleep(1000);
        }

        [Then(@"the burger menu should close")]
        public void ThenTheBurgerMenuShouldClose()
        {
            Assert.That(!SD_Website.InventoryPage.GetBurgerMenu().Displayed);
        }

        [When(@"I click the reset button")]
        public void WhenIClickTheResetButton()
        {
            SD_Website.InventoryPage.AddProductToCart("add-to-cart-sauce-labs-backpack");
            Thread.Sleep(1000);

            SD_Website.InventoryPage.ClickResetAppButton();
            Thread.Sleep(2000);
        }

        [Then(@"all products are removed from the cart")]
        public void ThenAllProductsAreRemovedFromTheCart() // Need to figure out how to check the Shopping Cart Badge is enabled
        {
            Assert.That(!SD_Website.InventoryPage.GetShoppingCartBadge().Displayed);
        }

        [When(@"I click the Twitter button")]
        public void WhenIClickTheTwitterButton()
        {
            SD_Website.InventoryPage.ClickTwitterButton();
            Thread.Sleep(2000);
        }

        [Then(@"I am taken to the Sauce Labs Twitter page")]
        public void ThenIAmTakenToTheSauceLabsTwitterPage() // Sauce Labs (@saucelabs) / Twitter
        {
            SD_Website.CheckNewWindow(SD_Website.InventoryPage.GetTwitterUrl());
        }

        [When(@"I click the Facebook button")]
        public void WhenIClickTheFacebookButton()
        {
            SD_Website.InventoryPage.ClickFacebookButton();
        }

        [Then(@"I am taken to the Sauce Labs Facebook page")]
        public void ThenIAmTakenToTheSauceLabsFacebookPage() // Sauce Labs - Home | Facebook
        {
            SD_Website.CheckNewWindow(SD_Website.InventoryPage.GetFacebookUrl());
        }

        [When(@"I click the Linkedin button")]
        public void WhenIClickTheLinkedinButton()
        {
            SD_Website.InventoryPage.ClickLinkedinButton();
        }

        [Then(@"I am taken to the Sauce Labs Linkedin page")]
        public void ThenIAmTakenToTheSauceLabsLinkedinPage() // Sauce Labs: Overview | Linkedin
        {
            SD_Website.CheckNewWindow(SD_Website.InventoryPage.GetLinkedinUrl()); // Requires a Linkedin account to view the page.
        }

        [When(@"I click the Terms of Service button")]
        public void WhenIClickTheTermsOfServiceButton()
        {
            SD_Website.InventoryPage.ClickTermsOfServiceButton();
        }

        [Then(@"I am taken to the Sauce Labs Terms of Service page")]
        public void ThenIAmTakenToTheSauceLabsTermsOfServicePage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetTermsOfServiceUrl()));
        }

        [When(@"I click the Privacy policy button")]
        public void WhenIClickThePrivacyPolicyButton()
        {
            SD_Website.InventoryPage.ClickPrivacyPolicyButton();
        }

        [Then(@"I am taken to the Sauce labs Privacy Policy page")]
        public void ThenIAmTakenToTheSauceLabsPrivacyPolicyPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetPrivacyPolicyUrl()));
        }

        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}
