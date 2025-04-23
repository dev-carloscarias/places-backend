
namespace Places.Domain.Entities
{
    public class ReservationTransfer : EntityBase
    {
        public string Path { get; set; } = string.Empty;
        public ReservationTransferState ReservationTransferState { get; set; }
        public string RejectReason { get; set; } = string.Empty;
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; } = null!;
    }
}