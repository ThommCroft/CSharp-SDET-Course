using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebUITesting.Lib;

namespace WebUITesting.BDD.Steps
{
    [Binding]
    [Scope (Feature = "Inventory")]
    public class InventoryStepDefinitions : SharedStepDefinitions
    {
        [Given(@"I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            SD_Website.InventoryPage.GetInventoryPageUrl();
            Thread.Sleep(1000);
        }

        [When(@"I add a product ""([^""]*)"" to the cart")]
        public void WhenIAddAProductToTheCart(string productAddID)
        {
            SD_Website.InventoryPage.AddProductToCart(productAddID);
            Thread.Sleep(1000);
        }

        [Then(@"the cart icon displays the number of products in the cart")]
        public void ThenTheCartIconDisplaysTheNumberOfProductsInTheCart()
        {
            Assert.That(SD_Website.InventoryPage.GetShoppingCartBadgeNumber(), Is.EqualTo("1"));
        }

        [When(@"I remove an product ""([^""]*)"" from the cart")]
        public void WhenIRemoveAnProductFromTheCart(string productRemoveID)
        {
            SD_Website.InventoryPage.AddProductToCart("add-to-cart-sauce-labs-backpack");
            Thread.Sleep(1000);

            SD_Website.InventoryPage.RemoveProductFromCart(productRemoveID);
            Thread.Sleep(1000);
        }

        [Then(@"the product should be removed ""([^""]*)""")]
        public void ThenTheProductShouldBeRemoved(string productAddButtonID)
        {
            Assert.That(SD_Website.InventoryPage.ButtonID(productAddButtonID));
        }


        [When(@"I click the Cart button")]
        public void WhenIClickTheCartButton()
        {
            SD_Website.InventoryPage.ClickShoppingCartButton();
        }

        [Then(@"I am taken to the your cart page")]
        public void ThenIAmTakenToTheYourCartPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(SD_Website.YourCartPage.GetYourCartUrl()));
        }
    }
}
