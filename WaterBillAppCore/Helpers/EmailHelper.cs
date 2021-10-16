using System;
using MailKit.Net.Smtp;
using MimeKit;


namespace WaterBillAppCore.Helpers
{
    public class EmailHelper
    {
        public string AdminEmail { get; set; }
        public EmailHelper()
        {
            //AdminEmail = "Tamaln0212@gmail.com";
            AdminEmail = "mrnnmthembu@gmail.com";
        }
        public void SendMail(string body, string subject, string toEmail)
        {
            var message = new MimeMessage();
            // Sender
            message.From.Add(new MailboxAddress("noreply@ipay.co.za", "noreply@ipay.co.za"));
            message.To.Add(new MailboxAddress(subject, toEmail));
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };
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
