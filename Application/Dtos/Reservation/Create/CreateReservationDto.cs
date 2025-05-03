using System.ComponentModel.DataAnnotations;

namespace Places.Application.Dtos.Reservation.Create
{
    public class CreateReservationDTO
    {
        [Required]
        public int SiteId { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public int TotalAdults { get; set; }
        [Required]
        public int TotalChildren { get; set; }
        public int? SpecialPackageId { get; set; }
        public int? SpecialPackageQuantity { get; set; }
        [Required]
        public ReservationPaymentType ReservationPaymentType { get; set; }
        public List<ReservationAdditionalCostDto> AdditionalCosts { get; set; } = [];
        public List<ReservationSelectedTransportOptionDto> SelectedTransportOptions { get; set; } = [];

    }
}