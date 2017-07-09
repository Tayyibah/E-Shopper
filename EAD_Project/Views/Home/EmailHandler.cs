using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace EAD_Project.Views.Home
{
    public class EmailHandler
    {
        public static Boolean SendEmail(String toEmailAddress, String subject, String body)
        {
            try
            {
                String fromDisplayEmail = "tayyibahalauddin@gmail.com";
                String fromPassword = "teeba123456";

                String fromDisplayName = "GUA Admin"; //This can be any text
                MailAddress fromAddress = new MailAddress(fromDisplayEmail, fromDisplayName);

                MailAddress toAddress = new MailAddress(toEmailAddress);

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {

                    smtp.Send(message);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}


