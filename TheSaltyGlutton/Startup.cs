using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using TheSaltyGlutton.Models;

namespace TheSaltyGlutton
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
            /*
             * The SaltyDatabaseSettings class is used to store the appsettings.json file's SaltyDatabaseSettings property values. 
             * The JSON and C# property names are named identically to ease the mapping process. This class will also be added 
             * to the ConfigureServices method in Startup.cs (as a service obviously). This will allow the developer to refer
             * 
             * The configuration instance to which the appsettings.json file's SaltyDatabaseSettings section binds is registered 
             * in the Dependency Injection (DI) container. For example, a SaltyDatabaseSettings object's ConnectionString property 
             * is populated with the SaltyDatabaseSettings:ConnectionString property in appsettings.json. 
             * 
             * The ISaltyDatabaseSettings interface is registered in DI with a singleton service lifetime. When injected, the 
             * interface instance resolves to a SaltyDatabaseSettings object.
             */

            services.Configure<SaltyDatabaseSettings>(
                Configuration.GetSection(nameof(SaltyDatabaseSettings)));

            services.AddSingleton<ISaltyDatabaseSettings>(s =>
                s.GetRequiredService<IOptions<SaltyDatabaseSettings>>().Value);


            services.AddControllersWithViews();

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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
