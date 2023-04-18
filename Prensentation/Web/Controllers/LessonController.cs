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
    public class LessonController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        public LessonController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [Route("bai-hoc/{lesson}")]
        public IActionResult Index(string lesson)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}