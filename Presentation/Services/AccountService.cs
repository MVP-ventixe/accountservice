using Microsoft.AspNetCore.Identity;

namespace Presentation.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<IdentityUser> _userManager;

    public AccountService(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IdentityResult> CreateAsync(string email, string password)
    {
        var user = new IdentityUser { UserName = email, Email = email };
        var result = await _userManager.CreateAsync(user, password);
        return result;
    }
}
