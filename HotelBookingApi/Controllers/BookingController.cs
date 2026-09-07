using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    [HttpPost(Name = "BookFlight")]
    public IActionResult Post()
    {
        return Ok();
    }
}
