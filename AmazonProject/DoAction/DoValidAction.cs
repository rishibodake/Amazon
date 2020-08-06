
using AmazonProject.Data;
using AmazonProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AmazonProject
{
    public static class DoValidAction
    {
        public static void SignIn(IWebDriver driver)
        {
            WelcomePage welcomePage = new WelcomePage(driver);
            welcomePage.LoginButton.Click();
            Thread.Sleep(1000);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email.SendKeys(ExcelDataAcces.AccessDataFromFile("Valid_Creds").Username);
            Thread.Sleep(1000);
            loginPage.Continue.Click();
            loginPage.Password.SendKeys(ExcelDataAcces.AccessDataFromFile("Valid_Creds").Password);
            Thread.Sleep(1000);
            loginPage.LoginSubmit.Click();

            HomePage homePage = new HomePage(driver);
            string validate = homePage.SignInValidationText.Text;
        }

        public static void SerachProduct(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver); 
            homePage.SearchBar.SendKeys("asus" + Keys.Enter);
            Thread.Sleep(5000);
            IList<IWebElement> items = driver.FindElements(By.XPath("//a[@class='a-link-normal a-text-normal']"));
            Thread.Sleep(5000);
            Console.WriteLine(items[1].Text);
            items[1].Click();
            string windwoe = driver.WindowHandles.Last();
            Thread.Sleep(5000);
            driver.SwitchTo().Window(windwoe);

            SearchResultPage searchResultPage = new SearchResultPage(driver);
            searchResultPage.AddToCart.Click();
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
