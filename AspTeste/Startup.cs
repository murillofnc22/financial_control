using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial.ApplicationApp.Interfaces;
using Financial.ApplicationApp.OpenApp;
using Financial.Domain.Interfaces.Generics;
using Financial.Domain.Interfaces.InterfaceFinancialMovement;
using Financial.Domain.Interfaces.InterfaceServices;
using Financial.Domain.Services;
using Financial.Infra.Configuration;
using Financial.Infra.Repository.Generic;
using Financial.Infra.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspTeste
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IGeneric<>), typeof(RespositoryGeneric<>));

            services.AddSingleton<IFinancialMovement, RepositoryFinancialMovement>();
            services.AddSingleton<InterfaceFinancialMovementApp, AppFinancialMovement>();
            services.AddSingleton<IServiceFinancialMovement, ServiceFinancialMovement>();

            services.AddControllersWithViews();

            services.AddDbContext<ContextBase>(option => option.UseSqlServer("Data Source=.; Initial Catalog=FINCONTROL; Integrated Security=False; User ID=sa; Password=sic742"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
