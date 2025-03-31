namespace Places.Infrastructure.Data.Configurations;

public class TranslateConfiguration : IEntityTypeConfiguration<Translate>
{
    public void Configure(EntityTypeBuilder<Translate> builder)
    {
        builder.Property(e => e.LanguageCode)
            .HasMaxLength(3)
            .HasColumnType("char");

        builder.HasIndex(e => new { e.CurrencyId, e.LanguageCode }, "IX_Translate_Currency_Language");

        builder.HasIndex(e => new { e.MessageId, e.LanguageCode }, "IX_Translate_Message_Language");

        builder.HasIndex(e => new { e.CommentId, e.LanguageCode }, "IX_Translate_Comment_Language");

        builder.HasIndex(e => new { e.CurrencyId, e.LanguageCode }, "IX_Translate_Currency_Language");

        builder.HasIndex(e => new { e.LanguageId, e.LanguageCode }, "IX_Translate_Language_Language");

        builder.HasIndex(e => new { e.SiteId, e.LanguageCode }, "IX_Translate_Site_Language");

        builder.HasIndex(e => new { e.CategoryId, e.LanguageCode }, "IX_Translate_Category_Language");
    }
}