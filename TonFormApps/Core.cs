using System;
using System.Collections.Generic;

using System.Web;
using System.Net;
using System.Net.Mail;
using System.Reflection;





namespace FormApps
{
    public class Core
    {


        private static string _xIDNum = "";
        private static string _xID = "";
        //private static string _loginID = "6h9Lu5pLHX";
        //private static string _tranKey = "9wS9yu6fR35mB375";

        private static string _loginID = "5sntUC8N6a";
        private static string _tranKey = "2956eQH2meub5UXx";


        public static string xIDNum
        {
            get{return _xIDNum;} set { _xIDNum = value;}
        }
        public static string xID
        {
            get{return _xID;} set {_xID = value;}
        }
        public static string loginID
        {
            get { return _loginID; }
            //set { _loginID = value; }
        }

        public static string tranKey
        {
            get { return _tranKey; }
            //set { _tranKey = value; }
        }

        //Mailing
        public static string mailSentFrom = "IHeartIT@newmarket.ca";
        //public static string mailServer = "mail.newmarket.ca";
        public static string mailServer = "172.16.0.97";
        public static string windowsLogin = "iheartit";
        public static string windowsPassword = "Love2help";

        //public static string mailSentFrom = "tonformapps@outlook.com";
        //public static string mailServer = "smtp-mail.outlook.com";
        //public static string windowsLogin = "tonformapps@outlook.com";
        //public static string windowsPassword = "tonadm#987";

        public static void sendMail(string to, string subject, string body)
        {
            //Use commas to list
            sendMail(to, subject, body, mailSentFrom, windowsLogin, windowsPassword);
        }
        public static void sendMail(string to, string subject, string body, string from, string username, string password)
        {
            body = "<font face=\"arial\">" + body.Replace("\r\n", "<br />") + "</font>";
            MailMessage objMail = new MailMessage(from, to, subject, body);

            string emailGuess = "";

            //if (Environment.UserName.Contains(' '))
            //    emailGuess = Environment.UserName.Split(' ')[0][0] + Environment.UserName.Split(' ')[1] + "@newmarket.ca";
            //else
            //    emailGuess = Environment.UserName + "@newmarket.ca";

            //objMail.ReplyToList.Add(emailGuess);
            objMail.IsBodyHtml = true;
            NetworkCredential objNC = new NetworkCredential(username, password);
            SmtpClient objsmtp = new SmtpClient(mailServer,25); //587
            //objsmtp.EnableSsl = true;
            objsmtp.Credentials = objNC;
            objsmtp.Send(objMail);
        }
    }
}