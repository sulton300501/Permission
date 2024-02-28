using EmailSenderApp.Domain.Entities.Models;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace EmailSenderApp.Application.Service.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMailAsync(EmailModel model)
        {
            string path = @"C:\angular\sender.html";

            using (var stream = new StreamReader(path))
            {
                model.Body = await stream.ReadToEndAsync();
            }


            var emailSetting = _configuration.GetSection("EmailSettings");

            var emailMessage = new MailMessage
            {
                From = new MailAddress(emailSetting["Sender"], emailSetting["Password"]),
                Subject = model.Subject,
                Body = model.Body,
                IsBodyHtml = true

            };
            emailMessage.To.Add(model.To);

            using   var smtpClient = new SmtpClient(emailSetting["MailServer"], int.Parse(emailSetting["MailPort"])){
                Port = Convert.ToInt32(emailSetting["MailPort"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(emailSetting["Sender"], emailSetting["Password"]),
                EnableSsl = true
            };

            await smtpClient.SendMailAsync(emailMessage);
               
            
            
           
          

        }
    }
}
