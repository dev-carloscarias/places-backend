namespace Places.Application.Dtos.Reservation.List
{

    public partial class ReservationListItem
    {
        public long Id { get; set; }
        public string SiteName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string HostPhoto { get; set; } = string.Empty;
        public string SitePhoto { get; set; } = string.Empty;
        public string ArrivalDate { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int ReservationStateValue { get; set; }
        public string ReservationState { get; set; } = string.Empty;
        public string PaymentUrl { get; set; } = string.Empty;
        public Details Details { get; set; } = null!;
    }

    public partial class Details
    {
        public string Basic { get; set; } = string.Empty;
        public long Adults { get; set; }
        public long Children { get; set; }
        public long Vehicles { get; set; }
        public List<string> Services { get; set; } = new();
        public string Package { get; set; } = string.Empty;
    }
}
