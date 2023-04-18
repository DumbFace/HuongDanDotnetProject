using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace CMS.Data.EFCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private KhangDB _context = null;
        private DbSet<T> table = null;

        public IQueryable<T> GetTable => table;

        public Repository()
        {
            this._context = new KhangDB();
            table = _context.Set<T>();
        }
        public Repository(KhangDB _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {

            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public T GetEntity(Expression<Func<T, bool>> whereFunc)
        {
            var entity = table.Where(whereFunc).FirstOrDefault();
            return entity;
        }

        public IEnumerable<TResult> GetAllFilter<TResult>(Expression<Func<T, bool>> whereFunc = null, Expression<Func<T, TResult>> projection = null)
        {
            IEnumerable<TResult> data = new List<TResult>();
            if (whereFunc != null && projection != null)
            {
                data = table.Where(whereFunc).Select(projection);
            }
            return data;
        }

        public IPagedList<TResult> Paging<TResult>(Expression<Func<T, bool>> whereFunc = null, Expression<Func<T, TResult>> projection = null, int page = 1, int pagesize = 10)
        {
            return table.Where(whereFunc).Select(projection).ToPagedList(page, pagesize);
        }
    }
}