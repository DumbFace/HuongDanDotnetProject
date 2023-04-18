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
using CMS.Data.EFCore;
using CMS.Core.Helper;
using CMS.Service.CategoryService;
using CMS.Service.ArticleService;
using Web.Factory;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Constrants.RootPath = env.ContentRootPath;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IArticleService, ArticleSerivce>();
            services.AddScoped<IContentFactory, ContentFactory>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            Constrants.TrustedConnectionLaptop = Configuration.GetConnectionString("TrustedConnectionLaptop");
            Constrants.TrustedConnectionDesktop = Configuration.GetConnectionString("TrustedConnectionDesktop");
            Constrants.AuthenticationConnection = Configuration.GetConnectionString("AuthenticationConnection");
            Constrants.DefaultConnectString = Configuration.GetConnectionString("DefaultConnectString");
            Constrants.UrlHost = Configuration.GetValue<string>("Url:UrlHost");
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

                endpoints.MapAreaControllerRoute(
                    name: "cp",
                    areaName: "cp",
                    pattern: "cp/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
