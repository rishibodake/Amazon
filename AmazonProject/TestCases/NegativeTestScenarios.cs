
using NUnit.Framework;
using OpenQA.Selenium;
using static AmazonProject.Validation;

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
            Assert.AreEqual(check,Expected_Incorrect_Mobile_SignIn_Test_Validation);           
        }


        [Test,Order(1)]
        public void Incorrect_Email_SignIn_Test()
        {
            DoInvalidActions.Incorrect_Email(driver);
            string check = driver.FindElement(By.ClassName("a-alert-heading")).Text;
            Assert.AreEqual(check,Expected_Incorrect_Email_SignIn_Test_Validation);
        }

        [Test,Order(2)]
        public void Incorrect_Password_Test()
        {         
            DoInvalidActions.Incorrect_Password(driver);
            string check = driver.FindElement(By.ClassName("a-list-item")).Text;
            Assert.AreEqual(check,Expected__Incorrect_Password_Test_Validation);
        }    
        
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
