using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class CheckoutCompletePage : SharedWebElements
    {
        private string _checkoutCompleteUrl = AppConfigReader.checkoutCompleteUrl;

        private IWebElement _backHomeButton => _seleniumDriver.FindElement(By.Id("back-to-products"));

        public CheckoutCompletePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetCheckoutCompleteUrl() => _checkoutCompleteUrl;
        public void ClickBackHomeButton() => _backHomeButton.Click();
    }
}
