using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using CMS.Service.CourseServices;
using CMS.Service.LessonServices;
using CMS.Service.TopicSerivces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Areas.cp.Controllers
{
    [Area("cp")]
    public class CourseController : Controller
    {
        private readonly ITopicService _toppicService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;

        private readonly ILogger<TopicController> _logger;

        public CourseController(ILogger<
        TopicController> logger,
        ICourseService courseService,
        ITopicService topicService,
        ILessonService lessonService
        )
        {
            _lessonService = lessonService;
            _courseService = courseService;
            _toppicService = topicService;
            _logger = logger;
        }
        public IActionResult Add([FromBody] Course obj, int id)
        {
            Topic topic = _toppicService.GetById(id);
            if (!string.IsNullOrEmpty(obj.Title))
            {
                topic.Courses.Add(obj);
                _toppicService.Save();
            }
            return Ok("OK");
        }

        public IActionResult Index(int id)
        {
            Course course = _courseService.GetById(id);
            return View(course);
        }

        public IActionResult GetModal(string id)
        {
            ViewBag.WhichModalSave = 0;
            ViewBag.Id = id;
            return PartialView("ModalCourse");
        }
        public IActionResult Delete(int id)
        {
            _courseService.Delete(id);
            _courseService.Save();
            return Ok("OK");
        }

        public IActionResult Update([FromBody] Course obj)
        {
            var course = _courseService.GetById(obj.Id);
            obj.DateCreated = obj.DateCreated.AddHours(7);
            obj.DateModified = DateTime.Now;
            course.Order = obj.Order;
            course.Title = obj.Title;
            course.Url = obj.Url;
            course.DateCreated = obj.DateCreated;
            course.DateModified = obj.DateModified;
            _courseService.Update(course);
            _courseService.Save();
            return Ok("OK");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}