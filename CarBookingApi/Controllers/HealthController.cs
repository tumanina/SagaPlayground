using Microsoft.AspNetCore.Mvc;

namespace CarBookingApi.Controllers;

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
