using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ap_email")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement Continue;

        [FindsBy(How = How.Id, Using = "ap_password")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        [CacheLookup]
        public IWebElement LoginSubmit;

    }
}
