namespace Places.Api.Validators;

public class LoginInputDtoValidator : AbstractValidator<LoginInputDto>
{
    public LoginInputDtoValidator()
    {
        RuleFor(m => m.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(ValidationConst.MaxEmailLength)
            .WithMessage(LanguageConst.InvalidEmail);

        RuleFor(m => m.Password)
            .NotEmpty()
            .MaximumLength(ValidationConst.MaxFieldLength)
            .WithMessage(LanguageConst.InvalidPassword);
    }
}