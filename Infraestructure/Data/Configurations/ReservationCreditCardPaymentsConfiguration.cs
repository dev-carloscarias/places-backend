using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Data.Configurations
{
    public class ReservationCreditCardPaymentsConfiguration : IEntityTypeConfiguration<ReservationCreditCardPayment>
    {
        public void Configure(EntityTypeBuilder<ReservationCreditCardPayment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Reservation)
                .WithMany(r => r.ReservationCreditCardPayments)
                .HasForeignKey(c => c.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
