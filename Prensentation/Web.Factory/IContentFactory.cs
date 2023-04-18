using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using X.PagedList;

namespace Web.Factory
{
    public interface IContentFactory
    {
        IEnumerable<ArticleViewModel> GetSiteMap();
        IPagedList<ArticleViewModel> GetArticlesPaging(CategoryEnum? type = null, int page = 1, int pagesize = 10);
        ArticleViewModel GetArticleById(int id);
    }
}