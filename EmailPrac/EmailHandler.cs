using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EmailPrac
{
    class EmailHandler
    {
        public static Boolean SendEmail(string tomailAddress,string subject,string body)
        {
            try
            {
                string fromEmail = "namramurtazai.28@gmail.com";
                string fromPassword = "17jan1963";

                string fromName = "Namra";
                MailAddress fromAddress = new MailAddress(fromEmail, fromName);

                MailAddress toAddress = new MailAddress(tomailAddress);

                //smtp client
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var msg = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(msg);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
