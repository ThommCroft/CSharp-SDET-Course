namespace SeleniumIntro
{
    public class Ap_SigninTests
    {
        // For Firefox, Install Selenium WebDriver GeckoDriver.

        // automationpractice.com/index.php

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenILandOnTheSignInPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // Maximise the browser so it is full screen
                driver.Manage().Window.Maximize();

                // Navigate to the AP Site
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

                // Grab the sign in link
                IWebElement signinLink = driver.FindElement(By.LinkText("Sign in"));
                signinLink.Click();

                // Wait to ensure response
                Thread.Sleep(5000);

                // Assert - that we have arrived on the sign in page
                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
            }
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnter4DigitPassword_WhenIClickTheSignInButton_TheIGetErrorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // Maximise the browser so it is full screen
                driver.Manage().Window.Maximize();

                // Navigate to the AP Site
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");

                Thread.Sleep(5000);

                // Grab the sign in link
                IWebElement emailField= driver.FindElement(By.Id("email"));
                IWebElement passwordField = driver.FindElement(By.Id("passwd"));

                emailField.SendKeys("tom@tom.com");
                passwordField.SendKeys("four");

                passwordField.SendKeys(Keys.Enter);

                // Wait to ensure response
                Thread.Sleep(5000);

                // Assert - that we have arrived on the sign in page
                IWebElement alert = driver.FindElement(By.ClassName("alert"));
                Assert.That(alert.Text.Contains("Invalid password."));
            }
        }
    }
}