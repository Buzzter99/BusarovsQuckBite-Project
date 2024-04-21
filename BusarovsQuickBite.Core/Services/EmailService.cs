using System.Net;
using System.Net.Mail;
using BusarovsQuckBite.Constants;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;

namespace BusarovsQuckBite.Services
{
    public class EmailService : IEmailSender
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUserName;
        private readonly string _smtpPassword;
        public EmailService(IConfiguration config)
        {
            _smtpServer = config["EmailConfiguration:SmtpServer"];
            _smtpPort = int.Parse(config["EmailConfiguration:SmtpPort"]);
            _smtpUserName = config["EmailConfiguration:SmtpUsername"];
            _smtpPassword = config["EmailConfiguration:SmtpPassword"];
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (SmtpClient smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_smtpUserName, _smtpPassword);
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(UserConstants.AdminEmail),
                    Subject = subject,
                    Body = htmlMessage,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}
