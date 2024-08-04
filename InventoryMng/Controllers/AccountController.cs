using Microsoft.AspNetCore.Mvc;

namespace InventoryMng.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
