
using AmazonProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AmazonProject
{
    public static class DoAction
    {
        public static void SignIn(IWebDriver driver)
        {
            WelcomePage welcomePage = new WelcomePage(driver);
            welcomePage.LoginButton.Click();
            Thread.Sleep(1000);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email.SendKeys("");
            Thread.Sleep(1000);
            loginPage.Continue.Click();
            loginPage.Password.SendKeys("");
            Thread.Sleep(1000);
            loginPage.LoginSubmit.Click();
        }

        public static void SignOut(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);

            Actions action = new Actions(driver);
            action.MoveToElement(homePage.AccountList).Perform();
            Thread.Sleep(2000);


            homePage.SignOut.Click();
        }
    }
}
