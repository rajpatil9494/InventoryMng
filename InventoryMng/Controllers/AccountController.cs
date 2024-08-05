using Microsoft.AspNetCore.Mvc;
using InventoryMng.Models;

namespace InventoryMng.Controllers
{
    public class AccountController : Controller
    {
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

           return View(); 
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(LoginModel loginModel)
        {
            return View();
        }
    }
}
