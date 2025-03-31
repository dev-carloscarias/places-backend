namespace Places.Infrastructure.Data.Configurations;

public class SiteConfiguration : IEntityTypeConfiguration<Site>
{
    public void Configure(EntityTypeBuilder<Site> builder)
    {
        builder.Navigation(d => d.Availabilities).AutoInclude();
        builder.Navigation(d => d.Translates).AutoInclude();
        builder.Navigation(d => d.Category).AutoInclude();
        builder.Navigation(d => d.AmenityBySites).AutoInclude();
        builder.Navigation(d => d.DataFiles).AutoInclude();

        builder.Property(e => e.ChildPrice)
            .HasColumnType("numeric(18,2)")
            .HasMaxLength(18)
            .HasPrecision(2);
        builder.Property(e => e.AdultPrice)
           .HasColumnType("numeric(18,2)")
           .HasMaxLength(18)
           .HasPrecision(2);
        builder.Property(e => e.TransportationPrice)
         .HasColumnType("numeric(18,2)")
         .HasMaxLength(18)
         .HasPrecision(2);

        builder.Property(e => e.TotalPrice)
            .HasColumnType("numeric(18,2)")
            .HasMaxLength(18)
            .HasPrecision(2);

        builder.Property(e => e.Latitude)
            .HasColumnType("float(10,7)");

        builder.Property(e => e.Longitude)
            .HasColumnType("float(10,7)");
    }
}