namespace Places.Application.Dtos.Reservation.Created
{
    public class CreatedReservationDto
    {
        public int ReservationId { get; set; }
        public string SiteName { get; set; } = string.Empty;
        public string SitePhoto { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string HostPhoto { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalAmmount { get; set; }
        public decimal Commision { get; set; }
        public int ReservationState { get; set; }
        public string ReservationStateName { get; set; } = string.Empty;
        public int TotalAdults { get; set; }
        public decimal AdultsAgreedPrice { get; set; }
        public int TotalChildren { get; set; }
        public decimal ChildAgreedPrice { get; set; }
        public int? SpecialPackageId { get; set; }
        public string SpecialPackageName { get; set; } = string.Empty!;
        public int? SpecialPackageQuantity { get; set; }
        public string PaymentUrl { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty!;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public List<CreatedReservationAdditionalCost> AdditionalCosts { get; set; } = [];
        public List<CreatedReservationTransportOption> SelectedTransportOptions { get; set; } = [];
    }
}
