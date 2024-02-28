﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Domain.Entities.Models.AuthModel
{
    public class User
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
