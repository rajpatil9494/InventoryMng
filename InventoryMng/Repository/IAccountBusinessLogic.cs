using InventoryMng.Models;
using Microsoft.AspNetCore.Identity;

namespace InventoryMng.Repository
{
    public interface IAccountBusinessLogic
    {
        Task<SignInResult> LoginUser(LoginModel loginModel);
    }
}