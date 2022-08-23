using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class YourCartPage : SharedWebElements
    {
        private string _yourCartUrl = AppConfigReader.yourcartUrl;

        private IWebElement _continueShoppingButton => _seleniumDriver.FindElement(By.Id("continue-shopping"));
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("checkout"));

        public YourCartPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetYourCartUrl() => _yourCartUrl;
        public void ClickContinueShoppingButton() => _continueShoppingButton.Click();
        public void ClickCheckoutButton() => _checkoutButton.Click(); // Should not be able to checkout with no Products in the cart. Possible Check condition here.

        public void ClickRemoveProductButton(string productID)
        {
            IWebElement removeButton = _seleniumDriver.FindElement(By.Id(productID));
            removeButton.Click();
        }
    }
}
