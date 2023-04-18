using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Helper;
namespace CMS.Core.Domain
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumb { get; set; }
        public string Url { get; set; }
        public string FriendLyUrl { get => Constrants.UrlHost + Url + "-" + Id + ".html"; }
        public string DateSiteMap { get => DatePublish.ToString("yyyy-MM-ddTHH:mm:00+07:00"); }
        public string DatePublishConvert { get => DatePublish.ToString("dd/MM/yyyy HH:mm"); }
        public DateTime DateModified { get; set; }
        public DateTime DatePublish { get; set; }
        public CategoryEnum Category { get; set; }
        public StatusCode Status { get; set; }
    }


    public enum ListView
    {
        Home,
        Trick,
        DesignPattern,

    }
}