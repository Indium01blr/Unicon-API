using Microsoft.AspNetCore.Mvc;
using Unicorn_Trade_api.Models;
using Unicorn_Trade_api.Services;


namespace Unicorn_Trade_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(UserService userService) : ControllerBase
    {

        [HttpGet(Name = "GetUser(name)")]
        public User GetUser(string name)
        {
            var response =  userService.GetUser(name);

            return response;
        }

    }
}
