using NUnit.Framework;

namespace AmazonProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void SignIn_Test()
        {
            DoAction.SignIn(driver);
        }

        [Test]
        public void SignOut_Test()
        {
            DoAction.SignOut(driver);
        }
    }
}
