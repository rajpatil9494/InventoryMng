using InventoryMng.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InventoryMng.Data
{
    public class LoginDbContext:IdentityDbContext
    {
      public  LoginDbContext(DbContextOptions<LoginDbContext>options):base(options)
      {

      }
        public DbSet<InventoryMng.Models.LoginModel> LoginModel { get; set; } = default!;
        public DbSet<InventoryMng.Models.RegisterModel> RegisterModel { get; set; } = default!;

         
    }
}
