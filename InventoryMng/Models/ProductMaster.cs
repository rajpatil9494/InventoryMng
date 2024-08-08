using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryMng.Models
{
    public class ProductMaster
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Enter the name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Enter the description")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Enter the created date ")]
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Enter the updated date")]
        [Column(TypeName = "date")]
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; } 
    }
}
