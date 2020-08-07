

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonProject.Pages
{
    public class AccountPage
    {
        public AccountPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.amazon.in/a/addresses?ref_=ya_d_c_addr']")]
        public IWebElement MyAddress;


        [FindsBy(How = How.Id, Using = "ya-myab-set-default-shipping-btn-1")]
        public IWebElement SetDefault;

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Amazon']")]
        public IWebElement HomeButton;
        

    }
}
