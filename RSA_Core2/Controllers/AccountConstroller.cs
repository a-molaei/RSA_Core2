using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RSA_Core2.Models;
using RSA_Core2.Services;

namespace RSA_Core2.Controllers
{
    [Route("api/[controller]")]

    public class AccountController : Controller
    {
        private readonly IJwtHandler _jwtHandler;

        public AccountController(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        [HttpGet("me")]
        [Authorize]
        public IActionResult Get()
        {
            return Content($"Hello {User.Identity.Name}");
        }

        [HttpPost("sign-in")]
        [AllowAnonymous]
        public IActionResult SignIn([FromBody]SignIn request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || request.Password != "secret")
            {
                return Unauthorized();
            }
            return Json(_jwtHandler.Create(request.Username));
        }
    }
}
