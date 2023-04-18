using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CMS.Core.Domain;
using X.PagedList;

namespace CMS.Data.EFCore
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T GetEntity(Expression<Func<T, bool>> whereFunc);
        IEnumerable<TResult> GetAllFilter<TResult>(Expression<Func<T, bool>> whereFunc = null,
                       Expression<Func<T, TResult>> projection = null);
        IPagedList<TResult> Paging<TResult>(Expression<Func<T, bool>> whereFunc = null,
                       Expression<Func<T, TResult>> projection = null, int page = 1, int pagesize = 10);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}