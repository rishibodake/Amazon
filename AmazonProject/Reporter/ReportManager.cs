
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Net;

namespace AmazonProject.Reporter
{
    public class ReportManager
    {
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;
        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\abhib\source\repos\AmazonProject\AmazonProject\Reports\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                string hostname = Dns.GetHostName();
                extent.AddSystemInfo("Oprating System", "Windows 10");
                extent.AddSystemInfo("Host Name", hostname);
                extent.AddSystemInfo("Browser", "Chrome");
                extent.AddSystemInfo("Environment", "Pre_Prod");
            }
            return extent;
        }
    }
   }
