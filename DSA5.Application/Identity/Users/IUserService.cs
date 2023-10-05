using DSA5.Application.Common.Interfaces;

namespace DSA5.Application.Identity.Users;

public interface IUserService : ITransientService
{
    Task<bool> ExistsWithEmailAsync(string email);
    Task<bool> ExistsWithNameAsync(string name);
    Task<string> CreateAsync(CreateUserRequest request, string origin);
}