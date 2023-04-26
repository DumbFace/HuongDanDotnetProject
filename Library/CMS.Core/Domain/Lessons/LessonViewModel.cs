using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;

namespace CMS.Core.Domain.Lessons
{
    public class LessonViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public StatusCode Status { get; set; }
        public bool IsDelete { get; set; }
        public Course Course { get; set; }
        public int Order { get; set; }
    }
}