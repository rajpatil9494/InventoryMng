using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryMng.Models
{
    public class EnquiryModel
    {

        public int id {  get; set; }    

        public int CustomerId { get; set; }

        [ForeignKey("ProductMaster")]
        public int ProdId { get; set; } 

        public ProductMaster ProductMaster { get; set; }
    }
}
