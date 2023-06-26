using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CMS.Data.EFCore;
using Domain.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Util.PermissionUtils;
using Serilog;

namespace Web.Areas.cp.Controllers
{
    [Area("cp")]
    public class Role : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<Role> _logger;

        public Role(ApplicationDbContext context, IMapper mapper, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<Role> logger)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
             .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            return PartialView((_mapper.Map<IEnumerable<RoleModel>>(_roleManager.Roles.AsEnumerable())));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public async Task<IActionResult> GetModal(string name = "")
        {
            var role = await _roleManager.FindByNameAsync(name);
            return PartialView("ShowModal", (_mapper.Map<RoleModel>(role)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleModel obj)
        {
            if (ModelState.IsValid)
            {
                var hasRole = await _roleManager.RoleExistsAsync(obj.Name);
                if (!hasRole)
                {
                    await _roleManager.CreateAsync(new IdentityRole(obj.Name));
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoleModel obj)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(obj.Id);
            if (role != null)
            {
                role.Name = obj.Name;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    Log.Information($"Stats {result.Succeeded.ToString()}");
                }
                else
                {
                    Log.Information($"Error: {result.Errors}");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            await _roleManager.DeleteAsync(role);
            return Content("Ok");
        }


        [HttpGet]
        public async Task<IActionResult> GetModalPermission(string name)
        {
            ViewBag.role = name;

            IdentityRole role = await _roleManager.FindByNameAsync(name);

            var roleClaims = await _roleManager.GetClaimsAsync(role);
            List<string> claimsAsString = new List<string>();

            foreach (Claim claim in roleClaims)
            {
                claimsAsString.Add(claim.Value);
            }

            ViewBag.lstPermission = PermissionUtil.GeneratePermissions();
            return PartialView("ModalPermission", claimsAsString);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePermission(List<string> permissions, string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            var allClaims = await _roleManager.GetClaimsAsync(role);

            //Remove all claims first
            using (var transaction = _context.Database.BeginTransaction())
            {
                foreach (var claim in allClaims)
                {
                    var testResult = await _roleManager.RemoveClaimAsync(role, claim);
                }
                transaction.Commit();
            }

            var allPermissions = permissions;
            foreach (var permission in allPermissions)
            {
                // if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))https://localhost:7020/Role#
                // {
                //     var result = await _roleManager.AddClaimAsync(role, new Claim("Permission", permission));
                // }
                var result = await _roleManager.AddClaimAsync(role, new Claim("Permission", permission));
            }

            return RedirectToAction("Index");
        }
    }
}