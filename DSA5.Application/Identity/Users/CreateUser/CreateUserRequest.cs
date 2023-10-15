namespace DSA5.Application.Identity.Users;

public sealed record CreateUserRequest(string UserName, string Email, string Password, string ConfirmPassword);