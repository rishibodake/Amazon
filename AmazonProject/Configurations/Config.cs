
namespace AmazonProject.Configurations
{
    public static class Config
    {
        public static string URL = System.Configuration.ConfigurationManager.AppSettings["url"];

        public static string Negative_Reports_Location = System.Configuration.ConfigurationManager.AppSettings["negative_reports"];
        public static string Positive_Reports_Location = System.Configuration.ConfigurationManager.AppSettings["positive_reports"];
    }
}
