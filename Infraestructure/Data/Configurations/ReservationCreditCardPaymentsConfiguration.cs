using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Data.Configurations
{
    public class ReservationCreditCardPaymentsConfiguration : IEntityTypeConfiguration<ReservationPayment>
    {
        public void Configure(EntityTypeBuilder<ReservationPayment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Reservation)
                .WithMany(r => r.ReservationPayments)
                .HasForeignKey(c => c.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
