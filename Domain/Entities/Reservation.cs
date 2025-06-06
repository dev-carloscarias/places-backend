namespace Places.Domain.Entities;

public class Reservation : EntityBase
{
    public DateTime ReservationDate { get; set; }
    public int TotalAdults { get; set; }
    public decimal AdultAgreedPrice { get; set; }
    public int TotalChildren { get; set; }
    public decimal ChildAgreedPrice { get; set; }
    public int SiteId { get; set; }
    public virtual Site? Site { get; set; }
    public ReservationState ReservationState { get; set; }
    public ReservationPaymentType ReservationPaymentType { get; set; }
    public virtual ICollection<ReservationTransfer> Transfers { get; set; } = [];
    public virtual ICollection<ReservationAdditionalCost> AdditionalCosts { get; set; } = [];
    public virtual ICollection<ReservationSelectedTransportOption> SelectedTransportOptions { get; set; } = [];
    public virtual ICollection<ReservationPayment> ReservationPayments { get; set; } = [];
    public int? SpecialPackageId { get; set; }
    public int? SpecialPackageQuantity { get; set; }
    public decimal? SpecialPackageAgreedPrice { get; set; }
    public virtual SpecialPackage? SpecialPackage { get; set; } = null!;
    public string CreditCardPaymentId { get; set; } = string.Empty;
    public string CreditCardPaymentUrl { get; set; } = string.Empty;
    public decimal TotalAmmount { get; set; }
    public decimal Commision { get; set; }
    public DateTime? PaymentDate { get; set; }
    public virtual User CreatedByUser { get; set; } = null!;
}