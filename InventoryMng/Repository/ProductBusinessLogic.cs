using InventoryMng.Data;
using InventoryMng.Models;

namespace InventoryMng.Repository
{
    public class ProductBusinessLogic : IProduct
    {
        public readonly LoginDbContext _loginDbContext;

        public ProductBusinessLogic(LoginDbContext loginDbContext)
        {
            this._loginDbContext = loginDbContext;
        }

        public List<ProductMaster> Getdata()
        {
            List<ProductMaster>pro=_loginDbContext.productMasters.ToList();
            return pro;
            
        }
    }
}
