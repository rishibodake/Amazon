using AmazonProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonProject.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class NegativeTestScenarios : BaseTest
    {
        [Test]
        public void Incorrect_Email_Test()
        {
            DoInvalidActions.Incorrect_Email(driver);
            string check = driver.FindElement(By.ClassName("a-alert-heading")).Text;
            Assert.AreEqual(check, "Incorrect phone number");


        }

        [Test]
        public void Incorrect_Password_Test()
        {
            DoInvalidActions.Incorrect_Password(driver);
            string check = driver.FindElement(By.ClassName("a-list-item")).Text;
            Assert.AreEqual(check, "Your password is incorrect");
        }
    }
}
