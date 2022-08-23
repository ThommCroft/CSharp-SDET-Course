using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class SharedWebElements
    {
        private string _loginPageUrl = AppConfigReader.baseUrl;
        private string _sauceLabsUrl = AppConfigReader.sauceLabsUrl;
        private string _twitterUrl = AppConfigReader.twitterUrl;
        private string _facebookUrl = AppConfigReader.facebookUrl;
        private string _linkedinUrl = AppConfigReader.linkedinUrl;
        private string _termsOfServiceUrl = AppConfigReader.termsOfServiceUrl;
        private string _privacyPolicyUrl = AppConfigReader.privacyPolicyUrl;

        protected IWebDriver _seleniumDriver;

        // Burger Side Bar
        protected IWebElement _burgerMenu => _seleniumDriver.FindElement(By.ClassName("bm-menu-wrap"));
        protected IWebElement _burgerButton => _seleniumDriver.FindElement(By.Id("react-burger-menu-btn"));
        protected IWebElement _burgerRedCrossButton => _seleniumDriver.FindElement(By.Id("react-burger-cross-btn"));
        protected IWebElement _allItemsButton => _seleniumDriver.FindElement(By.Id("inventory_sidebar_link")); // Does not close the Side bar.
        protected IWebElement _aboutButton => _seleniumDriver.FindElement(By.Id("about_sidebar_link"));
        protected IWebElement _logoutButton => _seleniumDriver.FindElement(By.Id("logout_sidebar_link"));
        protected IWebElement _resetAppStateButton => _seleniumDriver.FindElement(By.Id("reset_sidebar_link"));

        // Shopping Cart Button
        protected IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        protected IWebElement _shoppingCartBadge => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));

        // Footer Links
        protected IWebElement _socialTwitterButton => _seleniumDriver.FindElement(By.ClassName("social_twitter"));
        protected IWebElement _socialFacebookButton => _seleniumDriver.FindElement(By.ClassName("social_facebook"));
        protected IWebElement _socialLinkedinButton => _seleniumDriver.FindElement(By.ClassName("social_linkedin"));
        protected IWebElement _termsOfServicesButton => _seleniumDriver.FindElement(By.Id("terms_of_service_link")); // No button created.
        protected IWebElement _privacyPolicyButton => _seleniumDriver.FindElement(By.Id("privacy_policy_link")); // No button created.

        // Methods
        public string GetLoginPageUrl() => _loginPageUrl;
        public string GetSauceLabsUrl() => _sauceLabsUrl;
        public string GetTwitterUrl() => _twitterUrl;
        public string GetFacebookUrl() => _facebookUrl;
        public string GetLinkedinUrl() => _linkedinUrl;
        public string GetTermsOfServiceUrl() => _termsOfServiceUrl;
        public string GetPrivacyPolicyUrl() => _privacyPolicyUrl;
        public IWebElement GetBurgerMenu() => _burgerMenu;
        public void ClickBurgerMenuButton() => _burgerButton.Click();
        public void ClickBurgerRedCrossButton() => _burgerRedCrossButton.Click();
        public void ClickAllItemsButton() => _allItemsButton.Click();
        public void ClickAboutButton() => _aboutButton.Click();
        public void ClickLogOutButton() => _logoutButton.Click();
        public void ClickResetAppButton() => _resetAppStateButton.Click();
        public void ClickShoppingCartButton() => _shoppingCartButton.Click();
        public void ClickTwitterButton() => _socialTwitterButton.Click();
        public void ClickFacebookButton() => _socialFacebookButton.Click();
        public void ClickLinkedinButton() => _socialLinkedinButton.Click();
        public void ClickTermsOfServiceButton() => _termsOfServicesButton.Click();
        public void ClickPrivacyPolicyButton() => _privacyPolicyButton.Click();
        public IWebElement GetShoppingCartBadge() => _shoppingCartBadge;
        public string GetShoppingCartBadgeNumber() => _shoppingCartBadge.Text;
    }
}
