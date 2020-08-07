
using AmazonProject.Data;
using AmazonProject.ExceptionHandeling;
using AmazonProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace AmazonProject
{
    public static class DoValidAction
    {
        public static void SignIn(IWebDriver driver)
        {
            try
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
            catch
            {
                Take.ScreenShots(driver, "Failed_SignIn_Test");
                throw new CustomException(CustomException.TypeOfException.NO_SUCH_ELEMENT_FOUND, "Check Network");
            }
        }

        public static void Add_Address(IWebDriver driver)
        {
            WelcomePage welcomePage = new WelcomePage(driver);
            welcomePage.LoginButton.Click();

            AccountPage accountPage = new AccountPage(driver);
            accountPage.MyAddress.Click();
            Thread.Sleep(3000);
            accountPage.SetDefault.Click();
            Thread.Sleep(2000);
            accountPage.HomeButton.Click();                  
        }

        public static void SerachProduct(IWebDriver driver)
        {
            try
            {
                HomePage homePage = new HomePage(driver);
                homePage.SearchBar.SendKeys("wireless charger" + Keys.Enter);
                Thread.Sleep(5000);
                IList<IWebElement> items = driver.FindElements(By.XPath("//a[@class='a-link-normal a-text-normal']"));
                Thread.Sleep(5000);
                Console.WriteLine(items[0].Text);
                items[0].Click();
                string windwoe = driver.WindowHandles.Last();
                Thread.Sleep(5000);
                driver.SwitchTo().Window(windwoe);

                SearchResultPage searchResultPage = new SearchResultPage(driver);
                searchResultPage.AddToCart.Click();
                Thread.Sleep(2000);
                searchResultPage.CartPage.Click();
                Thread.Sleep(5000);
            }
            catch
            {
                Take.ScreenShots(driver, "Failed_SearchProduct_Test");
                throw new CustomException(CustomException.TypeOfException.NO_SUCH_ELEMENT_FOUND, "Check Network");
            }                      
        }
      
        public static void SignOut(IWebDriver driver)
        {
            try
            {
                HomePage homePage = new HomePage(driver);
                Actions action = new Actions(driver); //Using Action Class To Hover On Account & List

                action.MoveToElement(homePage.AccountList).Perform(); //Performing The Mouse Hover
                Thread.Sleep(2000);
                homePage.SignOut.Click();

                Take.ScreenShots(driver, "Valid_SignOut_Test");
            }
            catch
            {
                Take.ScreenShots(driver, "Failed_SignOut_Test");
                throw new CustomException(CustomException.TypeOfException.NO_SUCH_ELEMENT_FOUND, "Check Network");
            }
        }
    }
}
