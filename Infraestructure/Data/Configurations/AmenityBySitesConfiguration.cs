namespace Places.Infrastructure.Data.Configurations;

public class AmenityBySitesConfiguration : IEntityTypeConfiguration<AmenityBySite>
{
    public void Configure(EntityTypeBuilder<AmenityBySite> builder)
    {
        builder.Navigation(d => d.Amenity).AutoInclude();
    }
}