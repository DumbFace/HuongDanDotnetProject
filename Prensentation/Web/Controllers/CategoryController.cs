using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [Route("thu-thuat")]
        public IActionResult Trick(int page = 1, int pagesize = 5)
        {
            ViewBag.category = ListView.Trick;
            ViewBag.Page = page;
            ViewBag.PageSize = pagesize;
            ViewBag.Action = "Trick";
            return View("~/Views/Home/Index.cshtml");
        }


        [Route("mau-thiet-ke")]
        public IActionResult Pattern(int page = 1, int pagesize = 5)
        {
            ViewBag.category = ListView.DesignPattern;
            ViewBag.Page = page;
            ViewBag.PageSize = pagesize;
            ViewBag.Action = "Pattern";
             return View("~/Views/Home/Index.cshtml");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}