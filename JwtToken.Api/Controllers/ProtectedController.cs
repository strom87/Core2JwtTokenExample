using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JwtToken.Api.Controllers
{
    [ApiController]
    [Route("api/protected")]
    [Authorize(Policy = "BasicUser")]
    public class ProtectedController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return await Task.Run(() => Ok($"Welcome {User.Identity.Name}. This is a well protected text!"));
        }
    }
}