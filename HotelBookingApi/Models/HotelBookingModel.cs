namespace HotelBookingApi.Models;

public class HotelBookingModel
{
    public Guid BookingId { get; set; }

    public string HotelId { get; set; } = default!;

    public bool SimulateFailure { get; set; }
}
