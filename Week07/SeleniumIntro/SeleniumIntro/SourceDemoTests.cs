using OpenQA.Selenium.Interactions;

namespace SeleniumIntro
{
    public class SourceDemoTests
    {
        [Test]
        [Ignore("Example")]
        public void GivenAnInValidEmailAndInValidPassword_ReturnErrorMessageSadFace()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("nish@nish.com");
                passwordField.SendKeys("four");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);

                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("sadface"));
            }
        }

        [Test]
        [Ignore("Example")]
        public void GivenAnInValidCreds_ReturnErrorMessageSadFace()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");

            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("nish@nish.com");
                passwordField.SendKeys("four");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);

                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("sadface"));
            }
        }

        #region Activity Tests
        // Create tests for different paths on a website from the link: http://http://the-internet.herokuapp.com/ or https://www.saucedemo.com/
        // Remember to inspect the website to find the Element IDs.

        [Test]
        [Category("Activity: Happy Path")]
        public void GivenAStandardUserLogin_WhenIClickLogin_ThenIamTakenToInventoryPage()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");

            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("standard_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);

                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            }
        }

        [Test]
        [Category("Activity: Sad Path")]
        public void GivenALockedOutUserLogin_WhenIClickLogin_ReturnErrorMessageEpicSadFace()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");

            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("locked_out_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);

                IWebElement alert = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(alert.Text, Does.Contain("sadface"));
            }
        }

        [Test]
        [Category("Activity: Happy Path")]
        public void GivenIAmOnTheInventoryPage_WhenIClickTheAboutButtonOnTheMenu_IAmTakenToSauceLabsWebSite()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");

            using (IWebDriver driver = new ChromeDriver()) // options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("standard_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);

                Thread.Sleep(3000);

                IWebElement menuButton = driver.FindElement(By.ClassName("bm-burger-button"));
                menuButton.Click();

                Thread.Sleep(2000);

                IWebElement menu = driver.FindElement(By.ClassName("bm-item-list"));

                IWebElement aboutButton = driver.FindElement(By.Id("about_sidebar_link"));
                aboutButton.Click();

                Thread.Sleep(2000);

                Assert.That(driver.Url, Is.EqualTo("https://saucelabs.com/"));
            }
        }

        [Test]
        [Category("Activity: Happy Path")]
        public void GivenIAmOnTheInventoryPage_WhenIClickAddToCartOnAnItem_ItemIsPlacedInTheCart()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");

            using (IWebDriver driver = new ChromeDriver()) // options))
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(5000);

                IWebElement emailField = driver.FindElement(By.Id("user-name"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                emailField.SendKeys("standard_user");
                passwordField.SendKeys("secret_sauce");
                passwordField.SendKeys(Keys.Enter);

                Thread.Sleep(3000);

                IWebElement inventoryContainer = driver.FindElement(By.Id("inventory_container"));
                IWebElement inventoryList = inventoryContainer.FindElement(By.ClassName("inventory_list"));
                IWebElement inventoryItem = inventoryList.FindElement(By.ClassName("inventory_item"));
                IWebElement addToCart = inventoryItem.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
                addToCart.Click();

                Thread.Sleep(3000);

                IWebElement shoppingCartButton = driver.FindElement(By.ClassName("shopping_cart_container"));
                shoppingCartButton.Click();

                Thread.Sleep(3000);

                IWebElement shoppingCartItem = driver.FindElement(By.Id("item_4_title_link"));
                IWebElement backPackItem = shoppingCartItem.FindElement(By.ClassName("inventory_item_name"));

                Assert.That(backPackItem.Text, Is.EqualTo("Sauce Labs Backpack"));
            }
        }
        #endregion

        [Test]
        [Ignore("Example Test")]
        public void GivenIAmOnTheJohnLewisHomePage_WhenIHoverOverTheHomeAndGardenElement_ThenClickOnTheBeddingLink_ThenIAllBeddingRelatedItemsShouldBeDisplayed()
        {
            // create a new web driver so we can start to interact with the page
            using (IWebDriver driver = new ChromeDriver())
            {
                // Arrange                
                // maximize the browser so it is full screen
                driver.Manage().Window.Maximize();

                // navigate to the John Lewis homepage
                driver.Navigate().GoToUrl("https://www.johnlewis.com/");

                // Find the "Home & Garden" element
                var homeAndGardenElement = driver.FindElement(By.LinkText("Home & Garden"));

                //If an "allow cookies" pop up appeear if the homeAndGardenElement is null
                Thread.Sleep(2000);

                var acceptAllBookiesButton = driver.FindElement(By.ClassName("c-button-yMKB7"));
                acceptAllBookiesButton.Click();

                //Instantiate an action which we can use for more complex website interactions
                Actions action = new Actions(driver);
                action.MoveToElement(homeAndGardenElement).Perform();
                Thread.Sleep(5000);

                // Grab The "Bedding" link
                var beddingsLink = driver.FindElement(By.LinkText("Bedding"));
                beddingsLink.Click();

                //Check the title of the page is correct
                Assert.That(driver.Title.Contains("Bedding | Bed Sets and Bed Linen"));
            }
        }
    }
}
