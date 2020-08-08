
using AmazonProject.Pages;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;

namespace AmazonProject
{
    public static class Validation
    {

        public static string Expected_Incorrect_Mobile_SignIn_Test_Validation = "Incorrect phone number";
        public static string Expected_Incorrect_Email_SignIn_Test_Validation = "There was a problem";
        public static string Expected__Incorrect_Password_Test_Validation = "Your password is incorrect";

        public static string DoValidation(IWebDriver driver,string of)
        {

            HomePage homePage = new HomePage(driver);
            if (of.Contains("signin"))
            {
               return homePage.SignInValidationText.Text;
            }
            else
            {
                return homePage.SignOutValidationText.Text;
            }
            
        }
    }
}
