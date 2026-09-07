using FlightBookingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    [HttpPost(Name = "BookFlight")]
    public IActionResult Post(FlightBookingModel model)
    {
        return Ok();
    }
}
