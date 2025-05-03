using System.ComponentModel;

namespace Places.Domain.Define
{
    public enum ReservationPaymentType
    {
        [Description("Credit Card")]
        CreditCard = 1,
        [Description("Transfer")]
        Transfer = 2,
    }
}