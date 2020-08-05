
using AmazonProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
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
            loginPage.Email.SendKeys("rishibodake@hotmail.com");
            Thread.Sleep(1000);
            loginPage.Continue.Click();
            loginPage.Password.SendKeys("jocky1234#");
            Thread.Sleep(1000);
            loginPage.LoginSubmit.Click();

            HomePage homePage = new HomePage(driver);
            string validate = homePage.SignInValidationText.Text;
        }
      
        public static void SignOut(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            Actions action = new Actions(driver); //Using Action Class To Hover On Account & List

            action.MoveToElement(homePage.AccountList).Perform(); //Performing The Mouse Hover
            Thread.Sleep(2000);
            homePage.SignOut.Click();
        }
    }
}
