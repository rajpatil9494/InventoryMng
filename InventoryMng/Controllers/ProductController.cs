using InventoryMng.Models;
using InventoryMng.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InventoryMng.Controllers
{
    public class ProductController : Controller
    {
        public readonly IProduct product;

        public ProductController(IProduct product)
        {
            this.product = product;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Getproductlist()
        {
            List<ProductMaster> masterList = product.Getdata();
          return View(masterList); 
        }
    }
}
