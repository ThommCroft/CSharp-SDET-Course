using TechTalk.SpecFlow;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    [Scope(Feature = "CheckoutComplete")]
    public class CheckoutCompleteStepDefinitions : SharedStepDefinitions
    {
        [When(@"I am on checkout complete")]
        public void WhenIAmOnCheckoutComplete()
        {
            SD_Website.InventoryPage.ClickShoppingCartButton();
            Thread.Sleep(1000);

            SD_Website.YourCartPage.ClickCheckoutButton();
            Thread.Sleep(1000);

            SD_Website.CheckoutYourInformationPage.EnterFirstnameField("Tom");
            SD_Website.CheckoutYourInformationPage.EnterLastNameField("Croft");
            SD_Website.CheckoutYourInformationPage.EnterPostalCodeField("M15 6BH");
            Thread.Sleep(1000);

            SD_Website.CheckoutYourInformationPage.ClickContinueButton();
            Thread.Sleep(1000);

            SD_Website.CheckoutOverviewPage.ClickFinishButton();
            Thread.Sleep(1000);
        }

        [Then(@"I can return to the home page")]
        public void ThenICanReturnToTheHomePage()
        {
            SD_Website.CheckoutCompletePage.ClickBackHomeButton();
            Thread.Sleep(1000);

            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetInventoryPageUrl()));
        }
    }
}
