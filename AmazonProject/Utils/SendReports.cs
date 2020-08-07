

using System.Net;
using System.Net.Mail;

namespace AmazonProject
{
    public static class SendReports
    {
        public static void ByMail()
        {
            MailMessage mail = new MailMessage();
            string fromEmail = "";
            string password = "";
            string ToEmail = "rishibodake@gmail.com";
            mail.From = new MailAddress(fromEmail);
            mail.Subject = "Report Of The Automated Script";
            mail.To.Add(ToEmail);
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;
            mail.Attachments.Add(new Attachment(@"C:\Users\abhib\source\repos\AmazonProject\AmazonProject\Reports\index.html"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromEmail, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
