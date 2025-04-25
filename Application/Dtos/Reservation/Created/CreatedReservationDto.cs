using Places.Application.Dtos.Reservation.Create;

namespace Places.Application.Dtos.Reservation.Created
{
    public class CreatedReservationDto
    {
        public int ReservationId { get; set; }
        public SiteDto Site { get; set; } = null!;
        public SpecialPackageDto? SpecialPackage { get; set; }
        public DateTime ReservationDate { get; set; }
        public double Total { get; set; }
        public int ReservationState { get; set; }
        public int TotalAdults { get; set; }
        public decimal AdultsAgreedPrice { get; set; }
        public int TotalChildren { get; set; }
        public decimal ChildAgreedPrice { get; set; }
        public int? SpecialPackageId { get; set; }
        public int? SpecialPackageQuantity { get; set; }
        public List<CreatedReservationAdditionalCost> AdditionalCosts { get; set; } = [];
        public List<CreatedReservationTransportOption> SelectedTransportOptions { get; set; } = [];
    }
}
