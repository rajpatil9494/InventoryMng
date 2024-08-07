using InventoryMng.Data;
using InventoryMng.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InventoryMng
{
    public class Startup
    {
        private readonly IConfiguration _configuration;    

        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<LoginDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("SqlCon")));

            services.AddScoped<IUserAccount, AccountBusinessLogic>();

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<LoginDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
            });
            
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();    
            app.UseAuthorization(); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");


            });
        }
    }
}
