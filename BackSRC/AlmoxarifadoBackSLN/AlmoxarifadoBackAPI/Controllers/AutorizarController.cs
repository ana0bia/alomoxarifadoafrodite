using AlmoxarifadoBackAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AutorizarController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AutorizarController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }


        [HttpPost("/login")]
        public IActionResult Login(string usuario)
        {
            if (usuario == "reginaldo")
            {
                var token = _tokenService.GerarToken(usuario);
                return Ok(new { token });
            }
            else
            {
                return Unauthorized();
            }

            
        }
    }
}
