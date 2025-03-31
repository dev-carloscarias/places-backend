namespace Places.Infrastructure.Data.Configurations;

public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.Property(e => e.CurrencyCode)
            .HasMaxLength(3);

        builder.Property(e => e.Symbol)
            .HasMaxLength(10);

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18,2)")
            .HasMaxLength(18)
            .HasPrecision(2);
    }
}