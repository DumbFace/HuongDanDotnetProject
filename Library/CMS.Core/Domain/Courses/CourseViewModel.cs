using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Topics;

namespace CMS.Core.Domain.Courses
{
    public class CourseViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public TopicViewModel Topic { get; set; }
        // public List<Le MyProperty { get; set; }
        public int Order { get; set; }
    }
}