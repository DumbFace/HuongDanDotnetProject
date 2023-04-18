using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Domain
{
    [Table("tblArticle")]
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumb { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsDelete { get; set; }
        public string Url { get; set; }
        public StatusCode Status { get; set; }

    }

    public enum CategoryEnum
    {
        [Display(Name = "Thủ Thuật")]
        Trick,
        [Display(Name = "Design Pattern")]
        DesignPattern,
    }

    public enum StatusCode
    {
        [Display(Name = "Chỉ tôi xem")]
        Pending,
        [Display(Name = "Xuất bản")]
        Public,
    }
}