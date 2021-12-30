using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtic.Challenge.Web.Services.Auth.Models
{
    public class LoginRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
