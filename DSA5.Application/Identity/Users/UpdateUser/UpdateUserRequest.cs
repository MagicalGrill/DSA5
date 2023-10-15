namespace DSA5.Application.Identity.Users.UpdateUser;

public sealed record UpdateUserRequest(
    string Id, 
    string UserName, 
    string OldPassword, 
    string NewPassword,
    string ImageUrl
    );