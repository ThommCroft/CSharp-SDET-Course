using TechTalk.SpecFlow;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    [Scope(Feature = "CheckoutYourInformation")]
    public class CheckoutYourInformationStepDefinitions : SharedStepDefinitions
    {
        [Given(@"I am on checkout your information page")]
        public void GivenIAmOnCheckoutYourInformationPage()
        {
            SD_Website.InventoryPage.ClickShoppingCartButton();
            Thread.Sleep(1000);

            SD_Website.YourCartPage.ClickCheckoutButton();
            Thread.Sleep(1000);
        }

        [When(@"I enter a valid firstname ""([^""]*)"", lastname ""([^""]*)"" and zip/ postal code ""([^""]*)""")]
        public void WhenIEnterAValidFirstnameLastnameAndZipPostalCode(string firstname, string lastname, string postalCode)
        {
            SD_Website.CheckoutYourInformationPage.EnterFirstnameField(firstname);
            SD_Website.CheckoutYourInformationPage.EnterLastNameField(lastname);
            SD_Website.CheckoutYourInformationPage.EnterPostalCodeField(postalCode);
        }

        [Then(@"I press the continue button")]
        public void ThenIPressTheContinueButton()
        {
            SD_Website.CheckoutYourInformationPage.ClickContinueButton();
        }

        [Then(@"I am taken to the checkout overview page")]
        public void ThenIAmTakenToTheCheckoutOverviewPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.CheckoutOverviewPage.GetCheckoutOverviewUrl()));
        }

        [When(@"I enter invalid postal code ""([^""]*)""£\$""")]
        public void WhenIEnterInvalidPostalCode(string postalCode)
        {
            SD_Website.CheckoutYourInformationPage.EnterFirstnameField("Tom");
            SD_Website.CheckoutYourInformationPage.EnterLastNameField("Croft");
            SD_Website.CheckoutYourInformationPage.EnterPostalCodeField(postalCode);
        }


        [When(@"I do not enter firstname ""([^""]*)"", lastname ""([^""]*)"" or postal code ""([^""]*)""")]
        public void WhenIDoNotEnterFirstnameLastnameOrPostalCode(string firstname, string lastname, string postalCode)
        {
            SD_Website.CheckoutYourInformationPage.EnterFirstnameField(firstname);
            SD_Website.CheckoutYourInformationPage.EnterLastNameField(lastname);
            SD_Website.CheckoutYourInformationPage.EnterPostalCodeField(postalCode);
            Thread.Sleep(1000);

            SD_Website.CheckoutYourInformationPage.ClickContinueButton();
            Thread.Sleep(2000);
        }

        [Then(@"I cannot press the continue button")]
        public void ThenICannotPressTheContinueButton()
        {
            SD_Website.CheckoutYourInformationPage.PostCodeCheck();
            Thread.Sleep(2000);
        }

        [Then(@"stay on the checkout your information page")]
        public void ThenStayOnTheCheckoutYourInformationPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.CheckoutYourInformationPage.GetCheckoutYourInformationUrl()));
        }

        [Then(@"I recieve an error message ""([^""]*)""")]
        public void ThenIRecieveAnErrorMessage(string errorMessage)
        {
            Assert.That(SD_Website.CheckoutYourInformationPage.CheckErrorMessage(), Is.EqualTo(errorMessage));
        }
    }
}
