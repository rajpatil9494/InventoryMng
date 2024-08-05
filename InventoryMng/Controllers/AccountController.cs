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
        public IActionResult Login()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {

           return View(); 
        }
    }
}
