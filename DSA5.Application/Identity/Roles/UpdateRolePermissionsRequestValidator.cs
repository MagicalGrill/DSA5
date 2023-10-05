using DSA5.Application.Common.Validation;
using FluentValidation;

namespace DSA5.Application.Identity.Roles;

public class UpdateRolePermissionsRequestValidator : CustomValidator<UpdateRolePermissionsRequest>
{
    public UpdateRolePermissionsRequestValidator()
    {
        RuleFor(r => r.RoleId)
            .NotEmpty();

        RuleFor(r => r.Permissions)
            .NotNull();
    }
}