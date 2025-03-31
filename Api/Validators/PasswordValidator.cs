namespace Places.Api.Validators;

public class PasswordValidator : AbstractValidator<string>
{
    public PasswordValidator()
    {
        RuleFor(password => password)
            .NotEmpty()
            .WithMessage(LanguageConst.InvalidPassword);

        RuleFor(password => password)
            .MaximumLength(ValidationConst.MaxPasswordLength)
            .WithMessage(LanguageConst.InvalidPasswordMaxLength);

        RuleFor(password => password)
            .MinimumLength(ValidationConst.MinPasswordLength)
            .WithMessage(LanguageConst.InvalidPasswordMinLength);

        RuleFor(password => password)
            .Matches("[A-Z]").When(password => ValidationConst.MinUppercaseLetters > 0)
            .WithMessage(LanguageConst.InvalidPasswordUpperCase);

        RuleFor(password => password)
            .Matches("[a-z]").When(password => ValidationConst.MinLowercaseLetters > 0)
            .WithMessage(LanguageConst.InvalidPasswordLowerCase);

        RuleFor(password => password)
            .Matches("[0-9]").When(password => ValidationConst.MinDigits > 0)
            .WithMessage(LanguageConst.InvalidPasswordDigit);

        RuleFor(password => password)
            .Matches("[^a-zA-Z0-9]").When(password => ValidationConst.MinSpecialCharacters > 0)
            .WithMessage(LanguageConst.InvalidPasswordSpecialCharacter);
    }
}