using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;

namespace CMS.Core.Domain.Courses
{
    [Table("tblCourse")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public Topic Topic { get; set; }
        public int Order { get; set; }

    }
}