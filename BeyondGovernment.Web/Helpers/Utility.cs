using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;

namespace BeyondGovernment.Web.Helpers
{
    public static class Utility
    {
        public static TimeSpan TimeParse(string timeToParse)
        {
            TimeSpan time;
            time = DateTime.ParseExact(timeToParse, "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
            return time;
        }

        public static DateTime DateParse(string date)
        {
            DateTime dtParsed;
            string[] sDate = date.Split('/');
            string sDateTime = sDate[1] + '/' + sDate[0] + '/' + sDate[2];
            dtParsed = Convert.ToDateTime(sDateTime);
            return dtParsed;
        }

        public static void sendEmailViaWebApi(string password)
        {
            string subject = "Email Subject";
            string body = password;
            string FromMail = "postmaster@BeyondGovernmenthost.net";
            string emailTo = "sinha.abhisek@gmail.com";
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.BeyondGovernmenthost.net");
            mail.From = new MailAddress(FromMail);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("postmaster@BeyondGovernmenthost.net", "applesurf$28");
            SmtpServer.EnableSsl = false;
            SmtpServer.Send(mail);

          
        }
    }
}