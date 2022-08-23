using OpenQA.Selenium;
using WebUITesting.Configuration;
using System.Text.RegularExpressions;

namespace WebUITesting.Lib.Pages
{
    public class CheckoutYourInformationPage : SharedWebElements
    {
        private string _checkoutYourInformationUrl = AppConfigReader.checkoutInformationUrl;

        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _zipPostcodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _errorMessageBox => _seleniumDriver.FindElement(By.ClassName("error-message-container"));

        Regex ukPostCodeFormat = new Regex(@"^[A-Z]{1,2}[0-9R][0-9A-Z]? [0-9][ABD-HJLNP-UW-Z]{2}$");
        Regex usZipCodeFormat = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
        public string zipPostCodeCheck = "";

        public CheckoutYourInformationPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetCheckoutYourInformationUrl() => _checkoutYourInformationUrl;
        public void EnterFirstnameField(string firstname) => _firstNameField.SendKeys(firstname);
        public void EnterLastNameField(string lastName) => _lastNameField.SendKeys(lastName);

        public void EnterPostalCodeField(string postalcode)
        {
            zipPostCodeCheck = postalcode;
            _zipPostcodeField.SendKeys(postalcode);
        }

        public void ClickCancelButton() => _cancelButton.Click();

        public void ClickContinueButton() => _continueButton.Click();

        public void PostCodeCheck() // This is what I am expecting to happen after the user clicks the continue button by either entering a valid or invalid code
        {
            if (ukPostCodeFormat.IsMatch(zipPostCodeCheck))
            {
                _continueButton.Click();
            }
            else if (usZipCodeFormat.IsMatch(zipPostCodeCheck))
            {
                _continueButton.Click();
            }
            else
            {
                throw new ArgumentException("Zip/ Postal code does not match the UK or USA Format");
            }
        }

        public string CheckErrorMessage() => _errorMessageBox.Text;
    }
}
