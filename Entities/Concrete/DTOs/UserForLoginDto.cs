using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs
{
    public class UserForLoginDto 
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
