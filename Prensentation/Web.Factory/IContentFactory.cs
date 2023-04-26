using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using X.PagedList;

namespace Web.Factory
{
    public interface IContentFactory
    {
        IEnumerable<ArticleViewModel> GetSiteMap();
        TopicViewModel GetTopic(CategoryTopic? categoryTopic = null);

        LessonViewModel GetLesson(string url = "");
        // IPagedList<ArticleViewModel> GetArticlesPaging(CategoryEnum? type = null, int page = 1, int pagesize = 10);
        // ArticleViewModel GetArticleById(int id);
    }
}