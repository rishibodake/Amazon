using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AmazonProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Order(0)]
        public void SignIn_Test()
        {
            DoValidAction.SignIn(driver);           
            Assert.AreEqual(Validation.DoValidation(driver,"signin validation"), "Hello, Rishi");
        }

      

        [Test,Order(2)]
        public void SignOut_Test()
        {
           DoValidAction.SignOut(driver);
        }

       
    }
}
