using InventoryMng.Data;

namespace InventoryMng.Repository
{
    public class EnquiryBussinessLogic:IEnquiry
    {

        private readonly LoginDbContext _context;

        public EnquiryBussinessLogic(LoginDbContext context)
        {
         this._context = context;
        }

    }
}
