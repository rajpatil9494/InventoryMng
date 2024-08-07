using System.ComponentModel.DataAnnotations;

namespace InventoryMng.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Please Enter Email")]
        [EmailAddress]
        [Key]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage ="Password missmatched!")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please Confirm Password")]
        [DataType(DataType.Password)]   
        public string ConfirmPassword { get; set; }
    }
}
