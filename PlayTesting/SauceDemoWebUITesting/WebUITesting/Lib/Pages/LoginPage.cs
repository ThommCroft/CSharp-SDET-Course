using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class LoginPage
    {
        private string loginPageUrl = AppConfigReader.baseUrl;
        private IWebDriver _seleniumDriver;

        // Web Elements
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessageBox => _seleniumDriver.FindElement(By.ClassName("error-message-container"));

        // Constructor
        public LoginPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        // Methods
        public void VisitLoginPage() => _seleniumDriver.Navigate().GoToUrl(loginPageUrl);

        public void InputUsername(string username) => _usernameField.SendKeys(username);
        public void InputPassword(string password) => _passwordField.SendKeys(password);
        public void ClickLoginButton() => _loginButton.Click();
        public string GetErrorMessage() => _errorMessageBox.Text;
    }
}
