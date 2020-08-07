
using OpenQA.Selenium;
using System;

namespace AmazonProject
{
    public static class Take
    {
        public static string ScreenShots(IWebDriver driver, string testStatus)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalPath = path.Substring(0, path.LastIndexOf("bin")) + "Screenshots\\" + testStatus + ".Jpeg";
            string returnPath = new Uri(finalPath).LocalPath;
            screenshot.SaveAsFile(returnPath, ScreenshotImageFormat.Jpeg);
            return returnPath;
        }
    }
}
