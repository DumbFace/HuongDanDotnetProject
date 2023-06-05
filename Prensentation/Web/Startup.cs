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
using CMS.Service.TopicSerivces;
using CMS.Service.CourseServices;
using CMS.Service.LessonServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
            var connectionString = Configuration.GetConnectionString("DefaultConnectString") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<HuongDanNetDB>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectString")));

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectString")));

            services.AddDefaultIdentity<IdentityUser>(options => {

            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IArticleService, ArticleSerivce>();
            services.AddScoped<IContentFactory, ContentFactory>();
            services.AddScoped<ITopicService, TopicSerivce>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILessonService, LessonService>();

            services.AddScoped<IContentFactory, ContentFactory>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            Constrants.TrustedConnectionLaptop = Configuration.GetConnectionString("TrustedConnectionLaptop");
            Constrants.TrustedConnectionDesktop = Configuration.GetConnectionString("TrustedConnectionDesktop");
            Constrants.AuthenticationConnection = Configuration.GetConnectionString("AuthenticationConnection");
            Constrants.DefaultConnectString = Configuration.GetConnectionString("DefaultConnectString");
            Constrants.UrlHost = Configuration.GetValue<string>("Url:UrlHost");


            services.AddSession();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromMinutes(1);
                options.SlidingExpiration = true;
                options.AccessDeniedPath = "/Forbidden";
            });

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
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // app.UseCookiePolicy(cookiePolicyOptions);

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
