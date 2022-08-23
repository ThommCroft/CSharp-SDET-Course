using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class InventoryPage : SharedWebElements
    {
        private string _inventoryPageUrl = AppConfigReader.inventoryUrl;

        public IWebElement _inventoryItemLabelButton => _seleniumDriver.FindElement(By.ClassName("inventory_item_label"));
        public IWebElement _inventoryItemImageButton => _seleniumDriver.FindElement(By.ClassName("inventory_item_img"));
        
        // Item Sort Dropdown (Udemy course teaches how to test dropdowns)

        public InventoryPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetInventoryPageUrl() => _inventoryPageUrl;
        public void ClickProductsNameButton(string linkID)
        {
            IWebElement productNameButton = _inventoryItemLabelButton.FindElement(By.Id(linkID));
            productNameButton.Click();
        }

        public void ClickProductsImageButton(string linkID)
        {
            IWebElement productImageButton = _inventoryItemImageButton.FindElement(By.Id(linkID));
            productImageButton.Click();
        }

        public void AddProductToCart(string buttonID)
        {
            IWebElement addButton = _seleniumDriver.FindElement(By.Id(buttonID));
            addButton.Click();
        }

        public void RemoveProductFromCart(string buttonID)
        {
            IWebElement removeButton = _seleniumDriver.FindElement(By.Id(buttonID));
            removeButton.Click();
        }

        public bool ButtonID(string productButtonID)
        {
            return _seleniumDriver.FindElement(By.Id(productButtonID)) != null;
        }
    }
}
