using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Core.Domain.Topics;
using CMS.Service.CourseServices;
using CMS.Service.LessonServices;
using CMS.Service.TopicSerivces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class CourseController : Controller
    {

        private readonly ITopicService _toppicService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;
        private readonly ILogger<CategoryController> _logger;

        public CourseController(ILogger<CategoryController> logger,
            ITopicService topicService,
            ICourseService courseService,
            ILessonService lessonService
        )
        {
            _toppicService = topicService;
            _courseService = courseService;
            _lessonService = lessonService;
            _logger = logger;
        }

        [Route("khoa-hoc/{topicCategory}")]
        public IActionResult Index(CategoryTopic topicCategory)
        {
            ViewBag.TopicCategory = topicCategory;
            var topic = _toppicService.GetEntity(s => s.Category == topicCategory);
            return View(topic);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}