namespace CarBookingApi.Models;

public class CarBookingModel
{
    public Guid BookingId { get; set; }

    public string CarId { get; set; } = default!;

    public bool SimulateFailure { get; set; }
}
