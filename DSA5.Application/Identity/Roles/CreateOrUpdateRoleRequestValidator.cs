using DSA5.Application.Common.Validation;
using FluentValidation;

namespace DSA5.Application.Identity.Roles;

public class CreateOrUpdateRoleRequestValidator : CustomValidator<CreateOrUpdateRoleRequest>
{
    public CreateOrUpdateRoleRequestValidator(IRoleService roleService)
    {
        RuleFor(role => role.Name)
            .NotEmpty()
            .MustAsync(async (role, name, _) => !await roleService.ExistsAsync(name, role.Id))
            .WithMessage("Eine ähnliche Rolle existiert bereits.");
    }
}