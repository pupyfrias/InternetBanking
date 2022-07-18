using InternetBanking.Core.Applicacion.Dtos.Email;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using InternetBanking.Core.Domain.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Shared.Service 
{ 
    public class EmailService : IEmailService
    {
        private MailSettings _mailSetttings { get; }

        public EmailService(IOptions<MailSettings> option)
        {
            _mailSetttings = option.Value;
        }

        public async Task SendAsync(EmailRequest request)
        {
            try
            {
                MimeMessage email = new();
                email.Sender = MailboxAddress.Parse(_mailSetttings.DisplayName + " <" + _mailSetttings.EmailFrom + ">");
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                BodyBuilder body = new();
                body.HtmlBody = request.Body;
                email.Body = body.ToMessageBody();

                using (SmtpClient smtp = new())
                {
                    smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    smtp.Connect(_mailSetttings.SmtpHost, _mailSetttings.SmtpPort, SecureSocketOptions.StartTls);
                    smtp.Authenticate(_mailSetttings.SmtpUser, _mailSetttings.SmtpPass);
                    await smtp.SendAsync(email);
                    smtp.Disconnect(true);

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
