using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TexasTechProject.Models;
using TexasTechProject;
using Microsoft.AspNetCore.Builder;

namespace TexasTechProject
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CustomerContext>(optionsAction => optionsAction.UseSqlServer("CustomerDB"));
            services.AddControllersWithViews();


            
        }
    }
}
