namespace Places.Infrastructure.Data.Configurations;

public class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
{
    public void Configure(EntityTypeBuilder<UserType> builder)
    {
        builder.HasData(
            new UserType { Id = 1, Name = "Email", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new UserType { Id = 2, Name = "Facebook", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new UserType { Id = 3, Name = "Google", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now },
            new UserType { Id = 4, Name = "Apple", CreatedBy = 0, CreatedAt = DateTimeOffset.Now, UpdatedBy = 0, UpdatedAt = DateTimeOffset.Now }
            );
    }
}