using DSA5.Application.Common.Validation;
using FluentValidation;

namespace DSA5.Application.Identity.Users;

public sealed class CreateUserRequestValidator : CustomValidator<CreateUserRequest>
{
    public CreateUserRequestValidator(IUserService userService)
    {
        RuleFor(user => user.Email).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Ungültige Email-Addresse")
            .MustAsync(async (email, _) => !await userService.ExistsWithEmailAsync(email))
            .WithMessage((_, email) => $"Email {email} wird bereits verwendet");

        RuleFor(user => user.UserName).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .MinimumLength(6);

        RuleFor(user => user.Password).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .MinimumLength(6);

        RuleFor(user => user.ConfirmPassword).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Equal(user => user.Password)
            .WithMessage("Passwörter stimmen nicht überein");
    }
}