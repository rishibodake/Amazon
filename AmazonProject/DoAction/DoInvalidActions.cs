﻿using AmazonProject.Data;
using AmazonProject.Pages;
using OpenQA.Selenium;
using System.Threading;
namespace AmazonProject
{
    public static class DoInvalidActions
    {
        public static void Incorrect_Mobile(IWebDriver driver)
        {
            HomePage hpage = new HomePage(driver);
            hpage.AccountList.Click();
            Thread.Sleep(2000);
            LoginPage page = new LoginPage(driver);
            page.Email.SendKeys(ExcelDataAcces.AccessDataFromFile("Invalid_Creds").Username);
            Thread.Sleep(2000);

            page.Continue.Click();
        }

        public static void Incorrect_Email(IWebDriver driver)
        {

            LoginPage page = new LoginPage(driver);
            page.Email.Clear();
            page.Email.SendKeys("rishi");
            Thread.Sleep(2000);

            page.Continue.Click();
        }

        public static void Incorrect_Password(IWebDriver driver)
        {
            LoginPage page = new LoginPage(driver);
            page.Email.Clear();
            page.Email.SendKeys(ExcelDataAcces.AccessDataFromFile("Valid_Creds").Username);
            Thread.Sleep(2000);

            page.Continue.Click();

            page.Password.SendKeys(ExcelDataAcces.AccessDataFromFile("Invalid_Creds").Password);
            page.LoginSubmit.Click();
        }
    }
}
