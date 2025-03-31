namespace Places.Api.Validators;

public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
{
    public ChangePasswordDtoValidator()
    {
        RuleFor(m => m.UserId)
            .NotEmpty()
            .WithMessage(LanguageConst.InvalidUser);

        RuleFor(m => m.Password)
            .NotEmpty()
            .WithMessage(LanguageConst.InvalidPassword);

        RuleFor(m => m.Password)
            .NotEmpty()
            .SetValidator(new PasswordValidator())
            .WithMessage(LanguageConst.InvalidPassword);
    }
}