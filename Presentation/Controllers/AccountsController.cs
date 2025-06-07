using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController(IAccountService accountService) : ControllerBase
    {
        private readonly IAccountService _accountService = accountService;

        [HttpPost]

        public async Task<IActionResult> Create()
        {
            var result = await _accountService.CreateAsync();
            if (result.Succeeded)
            {
                return Ok("Account created successfully.");
            }
            return BadRequest(result.Errors);
        }
    }
}
