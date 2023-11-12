using System.Net;
using System.Net.Mail;

namespace Web.Helper
{
    public class EmailManager
    {
        string _sender = "phoenix-aims@outlook.com";
        string _password = "14oya12@LN";
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

        public async Task sendMail2(string recipient, string subject, string message)
        {
            try
            {
                var rec = _sender;
                
                // Send the email message.
                await Task.Run(() =>
                {
                    using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com"))
                    {
                        smtpClient.Port = 587; // Set the SMTP server port
                        smtpClient.Credentials = new NetworkCredential(_sender, _password); // Set your email and password
                        smtpClient.EnableSsl = true; // Use SSL encryption

                        using (MailMessage mailMessage = new MailMessage())
                        {
                            mailMessage.From = new MailAddress(rec);
                            mailMessage.Subject = subject;
                            mailMessage.Body = message;
                            mailMessage.To.Add(recipient);

                            // Add attachments if needed
                            // mailMessage.Attachments.Add(new Attachment("C:\\Path\\to\\attachment.pdf"));

                            //smtpClient.Send(mailMessage);
                        }
                    }
                });

            }
            catch (Exception ex)
            {
                var m = "Error sending email: " + ex.Message;
            }
        }

        //public void SendMail(string recipient, string subject, string message)
        //{
        //    SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

        //    client.Port = 587;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    System.Net.NetworkCredential credentials =
        //        new System.Net.NetworkCredential(_sender, _password);
        //    client.EnableSsl = true;
        //    client.Credentials = credentials;

        //    try
        //    {
        //        var mail = new MailMessage(_sender.Trim(), recipient.Trim());
        //        mail.Subject = subject;
        //        mail.Body = message;
        //        client.Send(mail);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw ex;
        //    }
        //}
    }
}