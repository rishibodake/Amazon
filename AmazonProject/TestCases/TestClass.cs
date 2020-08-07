using AmazonProject.Configurations;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonProject
{
    [TestFixture]
    [Parallelizable]
    public class TestClass : BaseTest
    {
        bool flag = false;
        ExtentReports report = null;

        [OneTimeSetUp]
        public void ExtendStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(Config.Positive_Reports);
            report.AttachReporter(htmlReporter);
        }

        [Test,Order(0)]
        public void SignIn_Test()
        {
            ExtentTest test = report.CreateTest("SignIn_Test").Info("Test To Sign In into Application");
            DoValidAction.SignIn(driver);
            Assert.AreEqual(Validation.DoValidation(driver,"signin validation"), "Hello, Rishi");
            test.Log(Status.Pass, "Sign In Succesful");
        }
       
        [Test,Order(2)]
        public void Search_Test()
        {
            ExtentTest test = report.CreateTest("Search_Test").Info("Test To Search The Product");
            DoValidAction.SerachProduct(driver);

            string validresult = driver.FindElement(By.XPath("//span[text()[contains(.,'Wireless Charger')]]")).Text;
            if(validresult.Contains("Wireless Charger"))
            {
                 flag = true;
            }
            Assert.IsTrue(flag);
            test.Log(Status.Pass, "Search Succesfull");
        }

        [Test,Order(3)]
        public void SignOut_Test()
        {
            ExtentTest test = report.CreateTest("SignOut_Test").Info("Test To Sign Out from Application");
            DoValidAction.SignOut(driver);

            string validresult = driver.FindElement(By.XPath("//*[text()[contains(.,'Email')]]")).Text;
            if (validresult.Contains("Email"))
            {
                flag = true;
            }
            Assert.IsTrue(flag);
            test.Log(Status.Pass, "Sign Out  Succesfull");
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush();         
        }
    }
}
