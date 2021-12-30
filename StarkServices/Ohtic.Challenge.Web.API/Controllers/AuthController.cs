using Microsoft.AspNetCore.Mvc;
using Ohtic.Challenge.Web.Services.Auth;
using Ohtic.Challenge.Web.Services.Auth.Models;
using System.Threading.Tasks;

namespace Ohtic.Challenge.Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult<LoginResponse>> Get([FromBody] LoginRequest request)
        {
            return Ok();
        }
    }
}
