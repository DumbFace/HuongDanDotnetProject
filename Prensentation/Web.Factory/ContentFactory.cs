using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
// using CMS.Core.Domain;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using CMS.Data.EFCore;
using LinqKit;
using X.PagedList;

namespace Web.Factory
{
    public class ContentFactory : IContentFactory
    {
        private readonly IRepository<Topic> _repoTopic;
        private readonly IRepository<Lesson> _repoLesson;


        public ContentFactory(
            IRepository<Topic> repoTopic,
            IRepository<Lesson> repoLesson
        )
        {
            _repoLesson = repoLesson;
            _repoTopic = repoTopic;
        }


        Expression<Func<Topic, TopicViewModel>> projectionTopic = s => new TopicViewModel()
        {
            Title = s.Title,
            Body = s.Body,
            Url = s.Url,
            Description = s.Description,
            Courses = s.Courses,
            Category = s.Category
        };
        Expression<Func<Lesson, LessonViewModel>> projectionLesson = s => new LessonViewModel()
        {
            Title = s.Title,
            Body = s.Body,
            Url = s.Url,
            Description = s.Description,
            Status = s.Status,
            IsDelete = s.IsDelete,
            Course = s.Course,
            Order = s.Order
        };

        public TopicViewModel GetTopic(CategoryTopic? categoryTopic = null)
        {
            var predicate = PredicateBuilder.New<Topic>(true);
            if (categoryTopic != null)
            { 
                predicate = predicate.And(p => p.Category == categoryTopic);
            }
            return _repoTopic.GetAllFilter(predicate, projectionTopic).FirstOrDefault();
        }

        public LessonViewModel GetLesson(string url = "")
        {
            var predicate = PredicateBuilder.New<Lesson>(true);
            predicate = predicate.And(p => p.Status == StatusCode.Public);
            predicate = predicate.And(p => p.IsDelete == false);

            if (url != "")
            {
                predicate = predicate.And(p => p.Url == url);
            }

            return _repoLesson.GetAllFilter(predicate, projectionLesson).FirstOrDefault();
        }

        public IEnumerable<CMS.Core.Domain.ArticleViewModel> GetSiteMap()
        {
            throw new NotImplementedException();
        }
    }
}