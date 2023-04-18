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
    public class CourseController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        public CourseController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [Route("khoa-hoc/{course}")]
        public IActionResult Index(string course)
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