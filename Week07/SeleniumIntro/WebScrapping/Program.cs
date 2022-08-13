using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebScrapping
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyCollection<IWebElement> results;
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                driver.Manage().Cookies.DeleteAllCookies();

                var search = driver.FindElement(By.Id("search_query_top"));
                search.SendKeys("Dress");
                search.SendKeys(Keys.Enter);

                results = driver.FindElements(By.ClassName("ajax_block_product"));

                using (StreamWriter sw = File.CreateText("results.csv"))
                {
                    sw.WriteLine("item,price,in_stock");
                    foreach (var item in results)
                    {

                        Console.WriteLine(item.Text);
                        string result = "";
                        string[] lines = item.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach (var line in lines)
                        {
                            result += line + ",";
                        }
                        sw.WriteLine(result);

                    }
                }
            }
        }
    }
}