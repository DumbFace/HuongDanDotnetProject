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
    public class LessonController : Controller
    {
        private readonly ITopicService _toppicService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;

        private readonly ILogger<TopicController> _logger;

        public LessonController(ILogger<
        TopicController> logger,
        ICourseService courseService,
        ITopicService topicService,
        ILessonService lessonService
        )
        {
            _courseService = courseService;
            _toppicService = topicService;
            _lessonService = lessonService;
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            Lesson lesson = _lessonService.GetById(id);
            return View(lesson);
        }

        public IActionResult Add([FromBody] Lesson obj, int id)
        {
            Course course = _courseService.GetById(id);
            if (!string.IsNullOrEmpty(obj.Title))
            {
                course.Lessons.Add(obj);
                _courseService.Save();
            }
            return Ok("OK");
        }

        public IActionResult GetModal(string id)
        {
            ViewBag.WhichModalSave = 1;
            ViewBag.Id = id;
            return PartialView("ModalLesson");
        }

        public IActionResult Delete(int id)
        {
            _lessonService.Delete(id);
            _lessonService.Save();
            return Ok("OK");
        }

        public IActionResult Update([FromBody] Lesson obj)
        {
            Lesson lesson = _lessonService.GetById(obj.Id);
            lesson.Title = obj.Title;
            lesson.DateModified =  DateTime.Now;
            lesson.DateCreated = obj.DateCreated.AddHours(7);
            lesson.Description = obj.Description;
            lesson.Order = obj.Order;
            lesson.Body = obj.Body;
            lesson.Url = obj.Url;
            lesson.Order = obj.Order;
            lesson.Status = obj.Status;
            // _lessonService.Update(obj);
            _lessonService.Save();
            return Ok("OK");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}