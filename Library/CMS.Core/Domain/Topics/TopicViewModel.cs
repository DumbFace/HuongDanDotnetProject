using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;

namespace CMS.Core.Domain.Topics
{
    public class TopicViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public CategoryTopic Category { get; set; }
    }
}