using Application.Interfaces;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendPlainEmailAsync(string to, string subject, string body, string from = null)
        {
            //// create message
            //var email = new MimeMessage();
            //email.Sender = MailboxAddress.Parse(from ?? _appSettings.EmailFrom);
            //email.To.Add(MailboxAddress.Parse(to));
            //email.Subject = subject;
            //email.Body = new TextPart(TextFormat.Html) { Text = html };

            //// send email
            //using var smtp = new SmtpClient();
            //smtp.Connect(_appSettings.SmtpHost, _appSettings.SmtpPort, SecureSocketOptions.StartTls);
            //smtp.Authenticate(_appSettings.SmtpUser, _appSettings.SmtpPass);
            //smtp.Send(email);
            //smtp.Disconnect(true);
        }
    }
}
