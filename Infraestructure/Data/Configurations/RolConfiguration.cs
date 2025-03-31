namespace Places.Infrastructure.Data.Configurations;

public class RolConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(e => e.Name).HasMaxLength(50);

        builder.HasData(
            new Role { Id = 1, Name = "Super Administrator", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Role { Id = 2, Name = "Regular User", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new Role { Id = 3, Name = "Administrator", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now }
        );
    }
}