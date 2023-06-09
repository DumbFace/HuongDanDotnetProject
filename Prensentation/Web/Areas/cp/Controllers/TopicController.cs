using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Topics;
using CMS.Service.TopicSerivces;
using Domain.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeIdentity.Permissions;

namespace Web.Areas.cp.Controllers
{
    [Authorize]
    [Area("cp")]
    public class TopicController : Controller
    {

        private readonly ITopicService _service;
        private readonly ILogger<TopicController> _logger;

        public TopicController(ILogger<TopicController> logger, ITopicService service)
        {
            _service = service;
            _logger = logger;
        }
        [Authorize(PermissionsAuthorize.Topic.View)]
        // [Route("topic/{whichTopic}")]
        public IActionResult Index()
        {
            // Topic topic = null;
            // topic = _service.GetEntity(s => s.Category == whichTopic);
            // if (topic == null)
            // {
            //     topic = new Topic
            //     {
            //         Title = "",
            //         Category = whichTopic,
            //         Body = "",
            //         Url = "",
            //         DateCreated = DateTime.Now,
            //         DateModified = DateTime.Now
            //     };
            //     _service.Insert(topic);
            //     _service.Save();
            // }

            return View();
        }

        [HttpPost]
        public IActionResult Update([FromBody] Topic obj)
        {
            obj.DateCreated = obj.DateCreated.AddHours(7);
            obj.DateModified = DateTime.Now;
            _service.Update(obj);
            _service.Save();
            return Ok("OK");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}