
using OpenQA.Selenium;

namespace AmazonProject
{
    public static class Take
    {
        public static Screenshot screenshot;
        public const string FileAddress = @"C:\Users\abhib\source\repos\AmazonProject\AmazonProject\ScreenShots\";
        public static void ScreenShots(IWebDriver driver, string test)
        {

            screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(FileAddress + test + ".jpeg", ScreenshotImageFormat.Jpeg);

        }
    }
}
