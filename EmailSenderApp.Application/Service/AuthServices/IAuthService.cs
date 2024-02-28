using EmailSenderApp.Domain.Entities.Models.AuthModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Service.AuthServices
{
    public interface IAuthService
    {
        public Task<string> GenereateToken(User user);
    }
}
