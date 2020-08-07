
using AmazonProject.Pages;
using OpenQA.Selenium;

namespace AmazonProject
{
    public static class Validation
    {
        
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
