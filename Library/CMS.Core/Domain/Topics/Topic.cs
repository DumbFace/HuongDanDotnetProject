using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
namespace CMS.Core.Domain.Topics
{
    [Table("tblTopic")]
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public CategoryTopic Category { get; set; }
    }


    public enum CategoryTopic
    {

        [Display(Name = "C#")]
        Csharp,
        MVC,
        WebAPI
    }
}