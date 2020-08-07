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
        [Test,Order(0)]
        public void SignIn_Test()
        {
            DoValidAction.SignIn(driver);
            Assert.AreEqual(Validation.DoValidation(driver,"signin validation"), "Hello, Rishi");
        }
       
        [Test,Order(2)]
        public void Search_Test()
        {
            DoValidAction.SerachProduct(driver);

            string validresult = driver.FindElement(By.XPath("//span[text()[contains(.,'Wireless Charger')]]")).Text;
            if(validresult.Contains("Wireless Charger"))
            {
                 flag = true;
            }
            Assert.IsTrue(flag);
        }

        [Test,Order(3)]
        public void SignOut_Test()
        {
            DoValidAction.SignOut(driver);

            string validresult = driver.FindElement(By.XPath("//*[text()[contains(.,'Email')]]")).Text;
            if (validresult.Contains("Email"))
            {
                flag = true;
            }
            Assert.IsTrue(flag);
        }      
    }
}
