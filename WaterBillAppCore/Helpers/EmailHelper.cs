using System;
using System.Collections.Generic;
using MailKit.Net.Smtp;
using MimeKit;


namespace WaterBillAppCore.Helpers
{
    public class EmailHelper
    {
        public void SendMail(string body, string subject, string[] emailaddresses)
        {
            InternetAddressList list = new InternetAddressList();
            var message = new MimeMessage();
            foreach (var emailaddress in emailaddresses) {
                list.Add(new MailboxAddress(emailaddress));
            }
            // Sender
            message.From.Add(new MailboxAddress("noreply@ipay.co.za", "noreply@ipay.co.za"));
            message.To.AddRange(list);
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {



                try
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("Tamaln0212@gmail.com", "Tamal_1234");
                    client.Send(message);
                }
                catch (Exception e)
                {

                }

                finally
                {
                    client.Dispose();
                }
            }


        }

        
    }


}
