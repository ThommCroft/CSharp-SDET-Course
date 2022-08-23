using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebUITesting.Lib;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    [Scope(Feature = "CheckoutOverview")]
    public class CheckoutOverviewStepDefinitions : SharedStepDefinitions
    {
        [When(@"I am on checkout overview with products in the cart")]
        public void WhenIAmOnCheckoutOverviewWithProductsInTheCart()
        {
            SD_Website.InventoryPage.AddProductToCart("add-to-cart-sauce-labs-backpack");
            Thread.Sleep(1000);

            SD_Website.InventoryPage.ClickShoppingCartButton();
            Thread.Sleep(1000);

            SD_Website.YourCartPage.ClickCheckoutButton();
            Thread.Sleep(1000);

            SD_Website.CheckoutYourInformationPage.EnterFirstnameField("Tom");
            SD_Website.CheckoutYourInformationPage.EnterLastNameField("Croft");
            SD_Website.CheckoutYourInformationPage.EnterPostalCodeField("M15 6BH");
            SD_Website.CheckoutYourInformationPage.ClickContinueButton();
            Thread.Sleep(1000);
        }

        [Then(@"I can see the products ""([^""]*)"" I am purchasing")]
        public void ThenICanSeeTheProductsIAmPurchasing(string productName)
        {
            Assert.That(SD_Website.CheckoutOverviewPage.CheckShoppingCartList(productName));
        }


        [Then(@"I can see the correct total price for all products")]
        public void ThenICanSeeTheCorrectTotalPriceForAllProducts() // Total of Products and Tax
        {
            // A Helper method which adds up all product prices and then adds on the Tax amount to determine the Total Price would be useful here.
            decimal expectedResult = 32.39M;

            Assert.That(SD_Website.CheckoutOverviewPage.CheckTotal(), Is.EqualTo(expectedResult));
        }
    }
}
