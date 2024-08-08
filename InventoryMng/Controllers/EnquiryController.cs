using Microsoft.AspNetCore.Mvc;

namespace InventoryMng.Controllers
{
    public class EnquiryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
