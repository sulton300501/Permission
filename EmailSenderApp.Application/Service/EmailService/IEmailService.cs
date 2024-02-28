using System;
using EmailSenderApp.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSenderApp.Domain.Entities.Models;

namespace EmailSenderApp.Application.Service.EmailService
{
    public interface IEmailService
    {
       public Task SendMailAsync(EmailModel model); 
    }
}
