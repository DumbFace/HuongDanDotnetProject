using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using CMS.Service.ArticleService;
using CMS.Core.Domain;
// using System.Linq.Expressions;
using CMS.Data.EFCore;
// using LinqKit;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Moq;
using CMS.Service.CategoryService;
using Web.Factory;
using X.PagedList;

namespace UnitTest
{
    public class TesTestRepositoryt
    {
        private readonly IArticleService articleService;

        public ArticleSerivce _article = null;
        public ContentFactory _contentFactory = null;
        public TesTestRepositoryt()
        {
            // articleService = _articleService;
            _article = new ArticleSerivce();

            _contentFactory = new ContentFactory(new Repository<Article>(), new Repository<Category>());
        }
        public Article GetArticleById(int id)
        {
            Article article = articleService.GetById(id);
            return article;
        }


        // [Fact]
        // public void GetArticle_Success()
        // {
        //     var dbMock = new ArticleSerivce();
        //     var dbMock2 = new CategoryService();

        //     // Arrange
        //     ContentFactory contentFactory = new ContentFactory(dbMock, dbMock2);

        //     // Act
        //     int id = 17;
        //     // var product = new Product(1, "Shoes", 200);
        //     var result = contentFactory.GetArticleById(id) != null ? true : false;

        //     // Assert
        //     Assert.True(result);
        //     // Assert.Equal(result, dbMock.ProductBeingProcessed);
        // }

        [Fact]
        public void TestSiteMap()
        {
            // SiteMapController 

            // Assert.Equal(5, paged.PageSize);
            // Assert.Equal(1, paged.PageNumber);
            // Assert.Equal(5, paged.Count);
        }

        [Fact]
        public void getArticlePaging()
        {
            IPagedList<ArticleViewModel> paged = _contentFactory.GetArticlesPaging(CategoryEnum.Trick, 1, 5);
            // var itemCount = paged.PageSize > 0;
            Assert.Equal(5, paged.PageSize);
            Assert.Equal(1, paged.PageNumber);
            Assert.Equal(5, paged.Count);
        }

        // [Fact]
        // public void getAritlcle_ShouldMatch()
        // {
        //     var expected = _article.GetById(17);
        //     var result = _article.GetEntity(s => s.Id == 17);

        //     Assert.Equal(expected, result);
        // }

        // [Theory]
        // [InlineData(StatusCode.Public, "a")]
        // public void getAllProjectionActive_ShouldMatch(StatusCode? status = null, string title = "")
        // {

        //     var actual = _article.GetTable.Where(s => s.Title.Contains(title)).Select(s => new ArticleViewModel
        //     {
        //         Id = s.Id,
        //         Title = s.Title,
        //         Description = s.Description,
        //         Thumb = s.Thumb,
        //         Url = s.Url,
        //         DatePublish = s.DatePublish,
        //         Category = s.Category,
        //         Status = s.Status
        //     }).ToArray();


        //     var predicate = PredicateBuilder.True<Article>();

        //     // if (status != null)
        //     // {
        //     //     predicate = predicate.And(p => p.Status == status);
        //     // }

        //     if (!string.IsNullOrEmpty(title))
        //     {
        //         predicate = predicate.And(p => p.Title.Contains(title));
        //     }

        //     Expression<Func<Article, ArticleViewModel>> projection = s => new ArticleViewModel()
        //     {
        //         Id = s.Id,
        //         Title = s.Title,
        //         Description = s.Description,
        //         Thumb = s.Thumb,
        //         Url = s.Url,
        //         DatePublish = s.DatePublish,
        //         Category = s.Category,
        //         Status = s.Status
        //     };
        //     var expected = _article.GetAllFilter(predicate, projection).ToArray();
        //     Assert.Equal(expected, actual);
        // }

    }

    // public static class PredicateBuilder
    // {
    //     public static Expression<Func<T, bool>> True<T>()
    //     {
    //         return f => true;
    //     }
    //     public static Expression<Func<T, bool>> False<T>() { return f => false; }

    //     public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1,
    //                                                         Expression<Func<T, bool>> expr2)
    //     {
    //         var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
    //         return Expression.Lambda<Func<T, bool>>
    //               (Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
    //     }

    //     public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
    //                                                          Expression<Func<T, bool>> expr2)
    //     {
    //         var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
    //         var test = Expression.Lambda<Func<T, bool>>(Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
    //         return test;
    //     }

    // }
}
