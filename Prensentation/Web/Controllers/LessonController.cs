using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Service.CourseServices;
using CMS.Service.LessonServices;
using CMS.Service.TopicSerivces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Factory;

namespace Web.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ITopicService _toppicService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;
        private readonly IContentFactory _contentFactory;

        public LessonController(ILogger<CategoryController> logger,
            ITopicService topicService,
            ICourseService courseService,
            ILessonService lessonService,
            IContentFactory contentFactory
        )
        {
            _contentFactory = contentFactory;
            _toppicService = topicService;
            _courseService = courseService;
            _lessonService = lessonService;
            _logger = logger;
        }

        [Route("bai-hoc/{url}")]
        public IActionResult Index(string url)
        {
            var lesson = _contentFactory.GetLesson(url);
            return View(lesson);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}