using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryMng.Models
{
    public class RateMaster
    {
        [Key]
        public int RateId { get; set; }

        [Required(ErrorMessage = "Enter the rate")]
        [Column(TypeName = "decimal(18,4)")] 
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "Enter the date")]
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "Enter the todate")]
        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage = "Enter the created date ")]
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Enter the updated date")]
        [Column(TypeName = "date")]
        public DateTime UpdatedDate { get; set; }



        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual ProductMaster Productmasters { get; set; }


    }
}
