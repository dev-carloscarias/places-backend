namespace Places.Api.Validators;

public class SiteRegisterValidator : AbstractValidator<SiteDto>
{
    public SiteRegisterValidator()
    {
        RuleFor(m => m.Title)
            .NotEmpty()
            .MaximumLength(ValidationConst.MaxFieldLength)
            .WithMessage(LanguageConst.InvalidName);

        RuleFor(m => m.Description)
            .NotEmpty()
            .MaximumLength(ValidationConst.MaxFieldLongLength)
            .WithMessage(LanguageConst.InvalidDescription);

        RuleFor(m => m.CountryId)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage(LanguageConst.InvalidCountry);

        RuleFor(m => m.CurrencyId)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage(LanguageConst.InvalidCountry);
    }
}