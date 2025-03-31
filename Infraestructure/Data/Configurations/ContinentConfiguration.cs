namespace Places.Infrastructure.Data.Configurations;

public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
{
    public void Configure(EntityTypeBuilder<Continent> builder)
    {
        builder.Property(e => e.Name).HasMaxLength(30);

        builder.HasData(
            new Continent { Id = 1, Name = "África", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Continent { Id = 2, Name = "América", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Continent { Id = 3, Name = "Asia", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Continent { Id = 4, Name = "Europa", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Continent { Id = 5, Name = "Oceanía", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now }
            );
    }
}