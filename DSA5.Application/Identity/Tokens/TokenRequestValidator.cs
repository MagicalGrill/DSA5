using DSA5.Application.Common.Validation;
using FluentValidation;

namespace DSA5.Application.Identity.Tokens;

public sealed class TokenRequestValidator : CustomValidator<TokenRequest>
{
    public TokenRequestValidator()
    {
        RuleFor(token => token.Email).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Ungültige Email-Addresse.");

        RuleFor(token => token.Password).Cascade(CascadeMode.Stop)
            .NotEmpty();
    }
}