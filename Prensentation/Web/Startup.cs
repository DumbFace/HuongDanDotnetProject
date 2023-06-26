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
using CMS.Core.Domain.Email;
using CMS.Service.EmailServices;
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

            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                // options.SignIn.RequireConfirmedAccount = true;
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();


            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
            });

            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            EmailConfiguration emailConfiguration = new EmailConfiguration();
            Configuration.GetSection("EmailConfiguration").Bind(emailConfiguration);

            // services.AddSingleton(emailConfiguration);

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<IEmailService, EmailService>();

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

            services.AddRazorPages();
            services.AddSession();


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

            // app.UseMvc(routes =>
            // {
            //     routes.MapRoute(
            //         name: "AreaDotNetTutorialRoute",
            //         template: "{area:exists}/{controller=Home}/{action=Index}"
            //     );
            // });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                                      name: "AreaDotNetTutorialRoute",
                                      areaName: "cp",
                                       pattern: "{area:exists}/{controller=Home}/{action=Index}"
                              );

                endpoints.MapAreaControllerRoute(
                    name: "cp",
                    areaName: "cp",
                    pattern: "cp/{controller=Home}/{action=Index}/{id?}").RequireAuthorization();

                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
