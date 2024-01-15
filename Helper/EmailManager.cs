using System.Net;
using System.Net.Mail;

namespace Web.Helper
{
    public class EmailManager
    {
        //string _sender = "phoenix-aims@outlook.com";
        //string _password = "14oya12@LN";
        public EmailManager()
        {
        }

        //public async Task SendEmailAsync(string to, string subject, string body)
        //{
        //    // Create a new email message.
        //    var emailMessage = new MimeMessage();
        //    emailMessage.From.Add(new MailboxAddress("sender@example.com"));
        //    emailMessage.To.Add(new MailboxAddress(to));
        //    emailMessage.Subject = subject;
        //    emailMessage.Body = new TextPart(TextFormat.Plain) { Text = body };

        //    // Send the email message.
        //    await Task.Run(() =>
        //    {
        //        using (var smtpClient = new SmtpClient("smtp.example.com"))
        //        {
        //            smtpClient.Send(emailMessage);
        //        }
        //    });
        //}

        //public async Task sendOutlookMail(string recipient, string subject, string message)
        //{
        //    try
        //    {
        //        var rec = _sender;
                
        //        // Send the email message.
        //        await Task.Run(() =>
        //        {
        //            using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com"))
        //            {
        //                smtpClient.Port = 587; // Set the SMTP server port
        //                smtpClient.Credentials = new NetworkCredential(_sender, _password); // Set your email and password
        //                smtpClient.EnableSsl = true; // Use SSL encryption

        //                using (MailMessage mailMessage = new MailMessage())
        //                {
        //                    mailMessage.From = new MailAddress(rec);
        //                    mailMessage.Subject = subject;
        //                    mailMessage.Body = message;
        //                    mailMessage.To.Add(recipient);

        //                    // Add attachments if needed
        //                    // mailMessage.Attachments.Add(new Attachment("C:\\Path\\to\\attachment.pdf"));

        //                    //smtpClient.Send(mailMessage);
        //                }
        //            }
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        var m = "Error sending email: " + ex.Message;
        //    }
        //}

        public void SendGmailMail(string recipient, string subject, string message)
        {
            string senderEmail = "phoenix.aims.office@gmail.com";
            string senderPassword = "14oya12@LN";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, senderPassword)
            };


            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(recipient);
            mailMessage.Subject = subject;
            mailMessage.Body = message;

            try
            {
                //smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}