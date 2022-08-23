using TechTalk.SpecFlow;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    [Scope(Feature = "YourCart")]
    public class YourCartStepDefinitions : SharedStepDefinitions
    {
        [Given(@"I am on the Your Cart page")]
        public void GivenIAmOnTheYourCartPage()
        {
            SD_Website.InventoryPage.AddProductToCart("add-to-cart-sauce-labs-backpack");
            Thread.Sleep(1000);

            SD_Website.InventoryPage.ClickShoppingCartButton();
            Thread.Sleep(1000);
        }

        [When(@"I have a product in the cart")]
        public void WhenIHaveAProductInTheCart() // Will fail as the Badge Element does not exist unless an item is in the cart
        {
            SD_Website.YourCartPage.GetShoppingCartBadgeNumber();
            Thread.Sleep(1000);
        }

        [Then(@"I can checkout")]
        public void ThenICanCheckout()
        {
            SD_Website.YourCartPage.ClickCheckoutButton();
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.CheckoutYourInformationPage.GetCheckoutYourInformationUrl()));
        }

        [When(@"I do not have a product in the cart")]
        public void WhenIDoNotHaveAProductInTheCart() // Will fail as the Badge Element does not exist unless an item is in the cart
        {
            SD_Website.YourCartPage.GetShoppingCartBadgeNumber();
            Thread.Sleep(1000);
        }

        [Then(@"I cannot checkout")]
        public void ThenICannotCheckout()
        {
            SD_Website.YourCartPage.ClickCheckoutButton();
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.YourCartPage.GetYourCartUrl()));
        }

        [When(@"I remove an item from the cart")]
        public void WhenIRemoveAnItemFromTheCart()
        {
            throw new PendingStepException();
        }

        [Then(@"It should no longer be in the cart")]
        public void ThenItShouldNoLongerBeInTheCart()
        {
            throw new PendingStepException();
        }

        [When(@"I click continue shopping button")]
        public void WhenIClickContinueShoppingButton()
        {
            SD_Website.YourCartPage.ClickContinueShoppingButton();
            Thread.Sleep(1000);
        }

        [Then(@"I am taken to the products page")]
        public void ThenIAmTakenToTheProductsPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.InventoryPage.GetInventoryPageUrl()));
        }
    }
}
