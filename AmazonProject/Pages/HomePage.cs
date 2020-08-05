
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonProject.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        [CacheLookup]
        public IWebElement AccountList;

        [FindsBy(How = How.Id, Using = "nav-item-signout")]
        [CacheLookup]
        public IWebElement SignOut;
    }
}
