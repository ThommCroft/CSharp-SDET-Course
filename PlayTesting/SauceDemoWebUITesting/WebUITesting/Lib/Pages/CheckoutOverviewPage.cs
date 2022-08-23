using OpenQA.Selenium;
using WebUITesting.Configuration;

namespace WebUITesting.Lib.Pages
{
    public class CheckoutOverviewPage : SharedWebElements
    {
        private string _checkoutOverviewUrl = AppConfigReader.checkoutOverviewUrl;

        private List<IWebElement> _cartProductList => new List<IWebElement>(_seleniumDriver.FindElements(By.ClassName("cart_item")));
        private IWebElement _subTotalLabel => _seleniumDriver.FindElement(By.ClassName("summary_subtotal_label"));
        private IWebElement _taxlabel => _seleniumDriver.FindElement(By.ClassName("summary_tax_label"));
        private IWebElement _totalLabel => _seleniumDriver.FindElement(By.ClassName("summary_total_label"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));

        public CheckoutOverviewPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetCheckoutOverviewUrl() => _checkoutOverviewUrl;
        public bool CheckShoppingCartList(string productName) // Testing that the product name is correct and that the correct product is in the shopping cart.
        {
            for (int i = 0; i < _cartProductList.Count(); i++)
            {
                IWebElement cartProduct = _cartProductList[i].FindElement(By.ClassName("inventory_item_name"));

                if (cartProduct.Text == productName)
                {
                    return true;
                }
            }

            return false;
        }

        public decimal CheckSubTotal() // This will be used to check the subTotal is equal to the total price of all Products in the Cart added together.
        {
            var subTotalString = _subTotalLabel.Text.Split('$');
            var subTotal = Convert.ToDecimal(subTotalString[1]);
            return subTotal;
        }

        public decimal CheckTaxAmount() // This will be used to check the tax is the correct amount
        {
            var taxString = _taxlabel.Text.Split('$');
            var tax = Convert.ToDecimal(taxString[1]);
            return tax;
        }

        public decimal CheckTotal() // This will be used to check the Total price is equal to the Sub Total plus the Tax Amount
        {
            var totalString = _totalLabel.Text.Split('$');
            var totalPrice = Convert.ToDecimal(totalString[1]);
            return totalPrice;
        }

        public void ClickCancelButton() => _cancelButton.Click();
        public void ClickFinishButton() => _finishButton.Click();
    }
}
