using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace ECommerce513.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            
            var senderEmail = _configuration["EmailSettings:Email"];
            var senderPassword = _configuration["EmailSettings:Password"];

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, senderPassword)
            };

            return client.SendMailAsync(
                new MailMessage(from: senderEmail, to: email, subject, htmlMessage)
                {
                    IsBodyHtml = true
                }
            );
        }
    }
}