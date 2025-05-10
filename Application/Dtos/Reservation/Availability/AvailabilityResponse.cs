namespace Places.Application.Dtos.Reservation.Availability
{
    public class AvailabilityResponse
    {
        public bool Available { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
