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
        ExtentReports report = null;

        [OneTimeSetUp]
        public void ExtendStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(Config.Negative_Reports_Location);
            report.AttachReporter(htmlReporter);
        }

        [Test]
        public void Incorrect_Email_Test()
        {
            ExtentTest test = report.CreateTest("Incorrect_Email_Test").Info("Test For Incorrect Email");
            DoInvalidActions.Incorrect_Email(driver);
            string check = driver.FindElement(By.ClassName("a-alert-heading")).Text;
            Assert.AreEqual(check, "Incorrect phone number");
            test.Log(Status.Pass, "Sign In Failed, Test Succesful");

            Take.ScreenShots(driver, "Invalid_MobileNumber_SignIn_Test");
        }

       [Test]
        public void Incorrect_Password_Test()
        {
            ExtentTest test = report.CreateTest("Incorrect_Password_Test").Info("Test For Incorrect Password");
            
            DoInvalidActions.Incorrect_Password(driver);
            string check = driver.FindElement(By.ClassName("a-list-item")).Text;
            Assert.AreEqual(check, "Your password is incorrect");
            test.Log(Status.Pass, "Test Passed");

            Take.ScreenShots(driver, "Invalid_Passord_SignIn_Test");
        }


        [OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush();
        }
    }
}
