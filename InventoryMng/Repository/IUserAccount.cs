using InventoryMng.Models;
using Microsoft.AspNetCore.Identity;

namespace InventoryMng.Repository
{
    public interface IUserAccount
    {
        Task<IdentityResult> CreateAsync(RegisterModel register);
        Task<SignInResult> LoginUser(LoginModel login);

    }
}
