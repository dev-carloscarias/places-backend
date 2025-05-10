using System.ComponentModel.DataAnnotations;

namespace Places.Application.Dtos.Reservation.Availability
{
    public class VerifySiteAvailabilityDto
    {
        [Required]
        public int SiteId { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public int TotalAdults { get; set; }
        [Required]
        public int TotalChildren { get; set; }
    }
}
