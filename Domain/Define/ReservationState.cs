using System.ComponentModel;
using System.Reflection;

namespace Places.Domain.Define
{
    public enum ReservationState
    {
        [Description("Creado")]
        Created = 1,
        [Description("Pago pendiente")]
        PendingPayment = 2,
        [Description("Pago aprobado")]
        Approved = 3,
        [Description("Pago en proceso")]
        ProcessingPayment = 4,
        [Description("Pago fallido")]
        Failed = 4
    }
    public static class EnumHelper
    {

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }

}