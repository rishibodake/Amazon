using AmazonProject.Configurations;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
namespace AmazonProject
{
    public class BaseTest
    {
        public static ExtentReports extent = Reporter.ReportManager.GetInstance();
        public static ExtentTest test;
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            BrowserFactory fact = new BrowserFactory();
            driver = fact.InitBrowser("chrome");
            driver.Url = Config.URL;
        }

        [TearDown]
        public void CloseUp()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string path = Take.ScreenShots(driver, TestContext.CurrentContext.Test.Name + TestStatus.Failed);
                test.Log(Status.Fail, "Test Failed");
                test.AddScreenCaptureFromPath(path);
                test.Fail(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Red));
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {               
                test.Log(Status.Pass, "Test Sucessful");
                test.Pass(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Green));
            }
            extent.Flush();
        }
    }
}
