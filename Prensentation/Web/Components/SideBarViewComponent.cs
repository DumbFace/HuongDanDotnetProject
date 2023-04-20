using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Topics;
using CMS.Service.TopicSerivces;
using Microsoft.AspNetCore.Mvc;
using Web.Factory;
using Web.Models;

namespace Web.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ITopicService _topicService;
        private readonly IContentFactory _content;
        public SideBarViewComponent(IContentFactory content,
            ITopicService topicService
        )
        {
            _topicService = topicService;
            _content = content;
        }

        public async Task<IViewComponentResult> InvokeAsync(CategoryTopic categoryTopic)
        {
            Topic topic = _topicService.GetEntity(s => s.Category == categoryTopic);
            IEnumerable<Course> courses = topic == null ? null : topic.Courses;
            // switch (categoryTopic)
            // {
            //     case CategoryTopic.Csharp:
            //         var topic = _topicService.GetEntity(s => s.Category == categoryTopic);
            //         courses = topic.Courses;
            //         break;
            //     case CategoryTopic.MVC:
            //         break;
            //     case CategoryTopic.WebAPI:
            //         break;

            // }
            return View(courses);
        }
    }
}