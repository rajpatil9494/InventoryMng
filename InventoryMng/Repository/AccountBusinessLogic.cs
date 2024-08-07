using InventoryMng.Models;
using InventoryMng.Repository;
using Microsoft.AspNetCore.Identity;

namespace InventoryMng.Repository
{
    public class AccountBusinessLogic : IUserAccount
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;  
        
        public AccountBusinessLogic(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IdentityResult>CreateAsync(RegisterModel register)
        {
            dynamic result = string.Empty;

            try
            {
                var user = new IdentityUser
                {
                    Email = register.Email,
                    UserName = register.Email
                };

                var task = Task.Run(async () =>
                {
                    return await _userManager.CreateAsync(user, register.Password);
                });
                return task.Result;

            }
            catch (Exception ex)
            {

            }
            return result;  
        }


        public async Task<SignInResult> LoginUser(LoginModel login)
        {
            dynamic result = string.Empty;

            result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);
            return result;
        }

       
    }
}


