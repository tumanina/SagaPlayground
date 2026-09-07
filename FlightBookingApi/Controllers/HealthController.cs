using Microsoft.AspNetCore.Mvc;

namespace FlightBookingApi.Controllers;

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
