
using OpenQA.Selenium;

namespace AmazonProject
{
    public static class DoAction
    {
        public static void Login(IWebDriver driver)
        {
            WelcomePage welcomePage = new WelcomePage(driver);
            welcomePage.LoginButton.Click();
        }
    }
}
