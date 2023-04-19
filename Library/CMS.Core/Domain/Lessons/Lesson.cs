using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;

namespace CMS.Core.Domain.Lessons
{
    [Table("tblLesson")]
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseId { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Course Course { get; set; }
        public int Order { get; set; }
    }
}