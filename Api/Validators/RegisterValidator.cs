namespace Places.Api.Validators;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(m => m.Email)
            .EmailAddress()
            .MaximumLength(ValidationConst.MaxEmailLength)
            .WithMessage(LanguageConst.InvalidEmail)
            ;

        RuleFor(m => m.FirstName)
            .NotEmpty()
            .MaximumLength(ValidationConst.MaxFieldLength)
            .WithMessage(LanguageConst.InvalidFirstName);

        RuleFor(m => m.LastName)
            .NotEmpty()
            .MaximumLength(ValidationConst.MaxFieldLength)
            .WithMessage(LanguageConst.InvalidLastName);

        RuleFor(m => m.UserTypeId)
            .IsInEnum()
            .WithMessage(LanguageConst.InvalidUserType);

        RuleFor(m => m.RoleId)
            .IsInEnum()
            .WithMessage(LanguageConst.InvalidRoleType);

        RuleFor(m => m.CountryId)
            .NotEmpty()
            .WithMessage(LanguageConst.InvalidCountry);

        RuleFor(m => m.Password)
            .SetValidator(new PasswordValidator());
    }
}