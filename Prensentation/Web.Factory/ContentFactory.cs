using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.EFCore;
using LinqKit;
using X.PagedList;

namespace Web.Factory
{
    public class ContentFactory : IContentFactory
    {
        private readonly IRepository<Article> _repoArticle;
        private readonly IRepository<Category> _repoCategory;
        public ContentFactory(
            IRepository<Article> repoArticle,
            IRepository<Category> repoCategory

        )
        {
            _repoArticle = repoArticle;
            _repoCategory = repoCategory;
        }
        Expression<Func<Article, ArticleViewModel>> projection = s => new ArticleViewModel()
        {
            Id = s.Id,
            Title = s.Title,
            Description = s.Description,
            Thumb = s.Thumb,
            Url = s.Url,
            DatePublish = s.DatePublish,
            Category = s.Category,
            Status = s.Status
        };

        Func<Article, ArticleViewModel> projectionFunc = s => new ArticleViewModel()
        {
            Id = s.Id,
            Title = s.Title,
            Description = s.Description,
            Thumb = s.Thumb,
            Url = s.Url,
            DatePublish = s.DatePublish,
            Category = s.Category,
            Status = s.Status,
            Content = s.Content
        };

        public ArticleViewModel GetArticleById(int id)
        {
            return projectionFunc(_repoArticle.GetById(id));
        }
        public IPagedList<ArticleViewModel> GetArticlesPaging(CategoryEnum? type = null, int page = 1, int pagesize = 10)
        {
            var predicate = PredicateBuilder.New<Article>(true);
            predicate = predicate.And(p => p.Status == StatusCode.Public);
            predicate = predicate.And(p => p.IsDelete == false);
            if (type != null)
            {
                predicate = predicate.And(p => p.Category == type);
            }
            return _repoArticle.Paging<ArticleViewModel>(predicate, projection, page, pagesize);
        }

        public IEnumerable<ArticleViewModel> GetSiteMap()
        {
            return (
                from article in _repoArticle.GetAll()
                where article.Status == StatusCode.Public && article.IsDelete == false
                orderby article.DatePublish descending
                select new ArticleViewModel
                {
                    Id = article.Id,
                    Url = article.Url,
                    DatePublish = article.DatePublish
                }
             );
        }
    }
}