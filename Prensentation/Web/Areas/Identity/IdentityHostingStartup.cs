// using System;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Identity.UI;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using WebApp1.Data;

// [assembly: HostingStartup(typeof(Web.Areas.Identity.IdentityHostingStartup))]
// namespace Web.Areas.Identity
// {
//     public class IdentityHostingStartup : IHostingStartup
//     {
//         public void Configure(IWebHostBuilder builder)
//         {
//             builder.ConfigureServices((context, services) => {
//                 services.AddDbContext<ApplicationDbContext>(options =>
//                     options.UseSqlServer(
//                         context.Configuration.GetConnectionString("DefaultConnectString")));

//                 services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                     .AddEntityFrameworkStores<ApplicationDbContext>();
//             });
//         }
//     }
// }