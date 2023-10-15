using DSA5.Application.Common.Interfaces;
using DSA5.Application.Identity.Users.UpdateUser;

namespace DSA5.Application.Identity.Users;

public interface IUserService : ITransientService
{
    Task<bool> ExistsWithEmailAsync(string email);
    Task<string> CreateAsync(CreateUserRequest request);
    Task UpdateAsync(UpdateUserRequest request);
    Task DeleteAsync(string id);
}