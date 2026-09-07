using CarBookingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBookingApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    [HttpPost(Name = "BookCar")]
    public IActionResult Post(CarBookingModel model)
    {
        return Ok();
    }
}
