using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using SharedDB.Models;

namespace SharedDB.Service
{
    public static class EmailService
    {
        public static async Task SendEmailAsync(string toEmail, string name)
        {
            string htmlBody = $@"<p><strong>Dear <em>{name}</em>,</strong></p>

                              <p><strong style=""color: green;"">Congratulations!</strong> We’re excited to let you know that your enrollment in <strong><em>Colegio de Kidapawan</em></strong> has been <strong>approved</strong>.</p>

                              Please watch your email for the next steps and important updates.</p>

                              <p>If you need any assistance, don’t hesitate to reach out to our <strong>admissions team</strong>.</p>

                              <p><strong>Best regards,</strong><br>
                              <em>Colegio de Kidapawan</em></p>";



            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Colegio de Kidapawan", "cdekidapawan@example.com"));
            message.To.Add(new MailboxAddress("Recipient", toEmail));
            message.Subject = "Enrollment Successful!";
            message.Body = new TextPart("html") { Text = htmlBody };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("cdekidapawan@gmail.com", "pkwa wlyp jaug hwbp");

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
        public static async Task SendEmailAsync(string toEmail, string name, string text)
        {
           


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Colegio de Kidapawan", "cdekidapawan@example.com"));
            message.To.Add(new MailboxAddress("Recipient", toEmail));
            message.Subject = "Enrollment Unsuccessful";
            message.Body = new TextPart("html") { Text = text };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("cdekidapawan@gmail.com", "pkwa wlyp jaug hwbp");

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
