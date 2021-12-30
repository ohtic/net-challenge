using Ohtic.Challenge.Web.Services.Auth.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ohtic.Challenge.Web.Services.Auth
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(string username, string password);
    }
}
