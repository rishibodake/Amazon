
using AmazonProject.Pages;
using OpenQA.Selenium;

namespace AmazonProject
{
    public static class DoAction
    {
        public static void Login(IWebDriver driver)
        {
            WelcomePage welcomePage = new WelcomePage(driver);
            welcomePage.LoginButton.Click();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email.SendKeys("");
            loginPage.Continue.Click();
            loginPage.Password.SendKeys("");
            loginPage.LoginSubmit.Click();


        }
    }
}
