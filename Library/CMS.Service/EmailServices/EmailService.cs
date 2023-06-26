using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using CMS.Core.Domain.Email;

namespace CMS.Service.EmailServices
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfiguration emailConfig = new EmailConfiguration();
        public EmailService(IConfiguration _config)
        {
            // emailConfig = _emailConfig;
            _config.GetSection("EmailConfiguration").Bind(emailConfig);
        }

        public void DisplayConfig()
        {
            Console.WriteLine($"SMTP Server: {emailConfig?.SmtpServer}");
            Console.WriteLine($"Port: {emailConfig?.Port}");
            Console.WriteLine($"Username: {emailConfig?.Username}");
            Console.WriteLine($"Password: {emailConfig?.Password}");
            Console.WriteLine($"Options: {(SecureSocketOptions)emailConfig?.SecureSocketOption}");
        }

        public async Task SendMailAsync(string to, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(emailConfig.Username));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = body
            };

            using var smtp = new SmtpClient();
            smtp.Connect(emailConfig.SmtpServer, emailConfig.Port, (SecureSocketOptions)emailConfig.SecureSocketOption);
            smtp.Authenticate(emailConfig.Username, emailConfig.Password);
            var result = smtp.Send(email);

            smtp.Disconnect(true);
        }
    }
}