using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.EFCore;
using CMS.Service.ArticleService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Web.Factory;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IContentFactory _content;

        public HomeController(
            IContentFactory content
        )
        {
            _content = content;
        }

        public IActionResult Index(int page = 1, int pagesize = 6)
        {
            ViewBag.category = ListView.Home;
            ViewBag.Page = page;
            ViewBag.PageSize = pagesize;
            ViewBag.Action = "Index";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
