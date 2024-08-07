using System.ComponentModel.DataAnnotations;

namespace InventoryMng.Models
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage ="Please Enter Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        [DataType(DataType.Password)]   
        public string Password { get; set; }

        public bool RememberMe { get; set; }    
    }
}
