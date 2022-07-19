using CoursatOnline.Data;
using CoursatOnline.Models;
using CoursatOnline.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("register")]
        [HttpPost("{role}")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model,Roles role)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model,role);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);


            return Ok(result);
        }

        


        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync([FromBody] TokenRequestModel model)//login
        {
            var result = await _authService.GetTokenAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);


            return Ok(result);
        }
    }
}
