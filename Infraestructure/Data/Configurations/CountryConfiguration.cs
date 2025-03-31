namespace Places.Infrastructure.Data.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(e => e.Iso2).HasMaxLength(2)
            .HasColumnType("char(2)");

        builder.Property(e => e.Iso3).HasMaxLength(2)
            .HasColumnType("char(3)");

        builder.Property(e => e.CountryCode).HasMaxLength(10);
    }
}