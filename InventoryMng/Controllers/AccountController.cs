using Microsoft.AspNetCore.Mvc;
using InventoryMng.Models;
using InventoryMng.Repository;

namespace InventoryMng.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAccount _Useraccount;

        public AccountController(IUserAccount userAccount)
        {
            this._Useraccount = userAccount;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task <IActionResult>Login()
        {
            return View();  
        }

        [HttpPost]
        public async Task <IActionResult> Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _Useraccount.LoginUser(login);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Invalid User Email or Password..");
                    return View();
                }
                return RedirectToAction("Register", "Account");
            }
           return View(); 
        }




        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel register)
        {
            if (ModelState.IsValid)
            {
                var result = await _Useraccount.CreateAsync(register);  
                if(result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return View();
        }
    }
}
