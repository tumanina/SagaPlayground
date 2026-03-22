using Microsoft.AspNetCore.Mvc;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet(Name = "CheckHealthStatus")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
