using Microsoft.AspNetCore.Mvc;
using Unicorn_Trade_api.Models;
using Unicorn_Trade_api.Services;
using System.Linq;
using System;


namespace Unicorn_Trade_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(UserService userService) : ControllerBase
    {

        [Route("GetUserDetails/{name}")]
        [HttpGet]
        public IActionResult GetUser(string name)
        {
            return (IActionResult)userService.GetUser(name);
        }

    }
}
