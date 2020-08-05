
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

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        [CacheLookup]
        public IWebElement SearchBar;

        [FindsBy(How = How.Id, Using = "nav-item-signout")]
        [CacheLookup]
        public IWebElement SignOut;

        [FindsBy(How = How.XPath, Using = "//span[text()='Hello, Rishi']")]
        [CacheLookup]
        public IWebElement SignInValidationText;

        [FindsBy(How = How.XPath, Using = "//title[text()='Amazon Sign In']")]
        [CacheLookup]
        public IWebElement SignOutValidationText;


    }
}
