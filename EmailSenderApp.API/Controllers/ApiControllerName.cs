using EmailSenderApp.Application.Service.EmailService;
using EmailSenderApp.Domain.Entities.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmailSenderApp.API.Controllers
{

    [Route("/api[controller]/[action]")]
    [ApiController]
    
    public class ApiControllerName : Controller
    {
    private readonly IEmailService _serviceEmail;

        public ApiControllerName(IEmailService serviceEmail)
        {
            _serviceEmail = serviceEmail;
        }
      

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailModel emailModel)
        {

            await _serviceEmail.SendMailAsync(emailModel);
            return Ok("yaratildi");
        }
        [HttpGet]
        public async Task<IActionResult> GetMail()
        {

          
            return Ok("Muvaffaqiyatli email yaratildi");
        }






    }
}
