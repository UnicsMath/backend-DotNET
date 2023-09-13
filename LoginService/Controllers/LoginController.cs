using LoginService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        // POST: Login
        [HttpPost]
        public void Post([FromBody] AccountCredentials accountCredentials)
        {
            Console.WriteLine(accountCredentials.Email);
            Console.WriteLine(accountCredentials.Password);
        }
    }
}
