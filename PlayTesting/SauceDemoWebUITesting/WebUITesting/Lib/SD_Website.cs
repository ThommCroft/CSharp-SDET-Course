using OpenQA.Selenium;
using WebUITesting.Configuration;
using WebUITesting.Lib.Pages;

namespace WebUITesting.Lib
{
    public class SD_Website<T> where T : IWebDriver, new()
    {
        public IWebDriver SeleniumDriver { get; set; }

        public LoginPage LoginPage { get; set; }
        public InventoryPage InventoryPage { get; set; }
        public YourCartPage YourCartPage { get; set; }
        public CheckoutYourInformationPage CheckoutYourInformationPage { get; set; }
        public CheckoutOverviewPage CheckoutOverviewPage { get; set; }
        public CheckoutCompletePage CheckoutCompletePage { get; set; }

        public SD_Website(int pageLoadTimeInSeconds = 4, int implicitWaitTimeInSeconds = 4, bool isHeadless = false)
        {
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadTimeInSeconds, implicitWaitTimeInSeconds, isHeadless).Driver;

            LoginPage = new LoginPage(SeleniumDriver);
            InventoryPage = new InventoryPage(SeleniumDriver);
            YourCartPage = new YourCartPage(SeleniumDriver);
            CheckoutYourInformationPage = new CheckoutYourInformationPage(SeleniumDriver);
            CheckoutOverviewPage = new CheckoutOverviewPage(SeleniumDriver);
            CheckoutCompletePage = new CheckoutCompletePage(SeleniumDriver);
        }

        public void CheckNewWindow(string newLinkUrl)
        {
            string originalBrowserWindow = SeleniumDriver.CurrentWindowHandle;

            foreach (string window in SeleniumDriver.WindowHandles)
            {
                if (originalBrowserWindow != window)
                {
                    Assert.That(SeleniumDriver.SwitchTo().Window(window).Url, Is.EqualTo(newLinkUrl));
                }
            }
        }
    }
}
