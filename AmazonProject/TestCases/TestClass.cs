using NUnit.Framework;

namespace AmazonProject
{
    [TestFixture]
    [Parallelizable]
    public class TestClass : BaseTest
    {
        [Test,Order(0)]
        public void SignIn_Test()
        {
            DoValidAction.SignIn(driver);           
            Assert.AreEqual(Validation.DoValidation(driver,"signin validation"), "Hello, Rishi");
        }

      
        [Test,Order(1)]
        public void Search_Test()
        {
            DoValidAction.SerachProduct(driver);
        }

        [Test,Order(2)]
        public void SignOut_Test()
        {
           DoValidAction.SignOut(driver);
        }

       
    }
}
