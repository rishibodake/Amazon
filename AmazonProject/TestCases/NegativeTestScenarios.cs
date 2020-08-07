using AmazonProject.Configurations;
using AmazonProject.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonProject.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class NegativeTestScenarios : BaseTest
    {      
        [Test,Order(0)]
        public void Incorrect_Mobile_SignIn_Test()
        {       
            DoInvalidActions.Incorrect_Mobile(driver);
            string check = driver.FindElement(By.ClassName("a-alert-heading")).Text;
            Assert.AreEqual(check, "Incorrect phone number");           
        }


        [Test,Order(1)]
        public void Incorrect_Email_SignIn_Test()
        {
            DoInvalidActions.Incorrect_Email(driver);
            string check = driver.FindElement(By.ClassName("a-alert-heading")).Text;
            Assert.AreEqual(check, "There was a problem");
        }

        [Test,Order(2)]
        public void Incorrect_Password_Test()
        {         
            DoInvalidActions.Incorrect_Password(driver);
            string check = driver.FindElement(By.ClassName("a-list-item")).Text;
            Assert.AreEqual(check, "Your password is incorrect");
        }    
        
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
