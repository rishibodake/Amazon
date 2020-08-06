using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace AmazonProject
{
    [TestFixture]
    [Parallelizable]
    public class TestClass : BaseTest
    {

        ExtentReports report = null;

        [OneTimeSetUp]
        public void ExtendStart()
        {
            report = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\abhib\source\repos\AmazonProject\AmazonProject\Reports\PositiveScenariosReport\");
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

      
        [Test,Order(1)]
        public void Search_Test()
        {
            ExtentTest test = report.CreateTest("Search_Test").Info("Test To Search The Product");
            DoValidAction.SerachProduct(driver);
            test.Log(Status.Pass, "Search Succesfull");
        }

        [Test,Order(2)]
        public void SignOut_Test()
        {
            ExtentTest test = report.CreateTest("SignOut_Test").Info("Test To Sign Out from Application");
            DoValidAction.SignOut(driver);
            test.Log(Status.Pass, "Sign Out  Succesfull");
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            report.Flush();         
        }
    }
}
