using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CMS.Data.EFCore;
using Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using PracticeIdentity.Models;

namespace Web.Areas.cp.Controllers
{
    [Area("cp")]
    public class UserManagerController : Controller
    {
        private readonly ILogger<UserManagerController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        //     private readonly IUserStore<IdentityUser> _userStore;
        // private readonly IUserEmailStore<IdentityUser> _emailStore;

        public UserManagerController(ILogger<UserManagerController> logger, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context, IMapper mapper, IUserStore<IdentityUser> userStore)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _mapper = mapper;
            // _userStore = userStore;
            // _emailStore = emailStore;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return PartialView((_mapper.Map<IEnumerable<UserViewModel>>(_userManager.Users.AsEnumerable())));
        }

        [HttpGet]
        public IActionResult GetModal()
        {
            return PartialView("RegisterModal", new RegisterModel());
        }

        [HttpGet]
        public async Task<IActionResult> GetModalEdit(string name)
        {
            var user = await _userManager.FindByNameAsync(name);

            var userViewModel = _mapper.Map<UserViewModel>(user);

            IList<string> rolesUser = await _userManager.GetRolesAsync(user);
            List<RoleViewModel> roleViewModels = _roleManager.Roles.Select(s => new RoleViewModel
            {
                Name = s.Name,
                Value = s.Name,
                Selected = false
            }).ToList();

            foreach (var roleViewModel in roleViewModels)
            {
                if (rolesUser.Any(s => s == roleViewModel.Name))
                {
                    roleViewModel.Selected = true;
                }
            }

            userViewModel.Roles = roleViewModels;
            return PartialView("EditModal", userViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = registerModel.Email,
                    Email = registerModel.Email
                };

                // await _userStore.SetUserNameAsync(user, registerModel.Email, CancellationToken.None);
                // await _emailStore.SetEmailAsync(user, registerModel.Email, CancellationToken.None);

                var result = await _userManager.CreateAsync(user, registerModel.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    //Add Claims
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Email, registerModel.Email));


                    await _userManager.AddClaimsAsync(user, claims);
                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    var user = await _userManager.FindByEmailAsync(userModel.Email);
                    user.PhoneNumber = userModel.PhoneNumber;
                    var result = await _userManager.UpdateAsync(user);

                    if (userModel?.Roles.Count > 0)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        if (userRoles.Count > 0)
                        {
                            await _userManager.RemoveFromRolesAsync(user, (IEnumerable<string>)userRoles);
                        }

                        var roleResult = await _userManager.AddToRolesAsync(user, userModel.Roles.Where(s => s.Selected == true).Select(s => s.Name));
                    }
                    transaction.Commit();
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            await _userManager.DeleteAsync(user);
            return Content("Ok");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}