using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace AmazonProject
{
    public class BrowserFactory
    {   
        IWebDriver driver;
        public IWebDriver InitBrowser(string browser)
        {           
                switch (browser)
                {
                    case "chrome":
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments("--disable-notifications", "--start-maximized");
                        driver = new ChromeDriver(chromeOptions);
                        break;
                    case "firefox":
                        FirefoxOptions firefoxOptions = new FirefoxOptions();
                        firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
                        driver = new FirefoxDriver(firefoxOptions);
                        break;
                }
                return driver;           
        }
    }
}
