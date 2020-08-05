
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonProject
{
    public class WelcomePage
    {
        public WelcomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        [CacheLookup]
        public IWebElement LoginButton;
    }
}
