using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonProject
{
    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {

            BrowserFactory fact = new BrowserFactory();
            driver = fact.InitBrowser("chrome");

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.amazon.in";

        }

        [OneTimeTearDown]
        public void CloseUp()
        {
            driver.Quit();
        }
    }
}
