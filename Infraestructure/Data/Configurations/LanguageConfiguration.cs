namespace Places.Infrastructure.Data.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(50);

        builder.Property(x => x.LanguageCode)
            .HasMaxLength(3);

        builder.Navigation(d => d.Translates)
            .AutoInclude();
    }
}