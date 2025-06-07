using Microsoft.AspNetCore.Identity;

namespace Presentation.Services;

public interface IAccountService
{
    Task<IdentityResult> CreateAsync(string email, string password);
}
