namespace FlightBookingApi.Models
{
    public class FlightBookingModel
    {
        public Guid BookingId { get; set; }

        public string FlightId { get; set; } = default!;

        public bool SimulateFailure { get; set; }
    }
}
