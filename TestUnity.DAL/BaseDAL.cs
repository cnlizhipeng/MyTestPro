using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections;
using EFWCF.Common;
using EFWCF.IDAL;
using System.Data.Entity.Validation;
using EFWCF.Models;
namespace EFWCF.DAL
{
    public abstract class BaseDAL<T> : IBaseDAL<T> where T : class,IModelBase
    {
        protected DbContext baseContext;
        protected IDbSet<T> objectSet;
        public BaseDAL(DbContext context)
        {
            baseContext = context;
            objectSet = baseContext.Set<T>();
        }

        public virtual IQueryable<T> GetQueryable(PropertyOrder orderby)
        {
            IQueryable<T> query = this.objectSet;
            if (orderby == null)
                return query;
            else
            {
                var property = typeof(T).GetProperty(orderby.PropertyName);
                var parameter = Expression.Parameter(typeof(T), "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExp = Expression.Lambda(propertyAccess, parameter);
                string methodName = orderby.IsDesc ? "OrderByDescending" : "OrderBy";
                MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { typeof(T), property.PropertyType }, query.Expression, Expression.Quote(orderByExp));
                return query.Provider.CreateQuery<T>(resultExp);
            }
        }

        public IQueryable<T> GetQueryablePage(Expression<Func<T, bool>> match, PagerInfo p, PropertyOrder orderby)
        {
            int currentPage = (p.CurrentPage < 1) ? 1 : p.CurrentPage;
            int pageSize = (p.PageDataCount <= 0) ? 20 : p.PageDataCount;

            int excludedRows = (currentPage - 1) * pageSize;
            IQueryable<T> query = GetQueryable(orderby).AsQueryable().Where(match);

            p.DataCount = query.Count();
            p.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(p.DataCount) / Convert.ToDouble(p.PageDataCount)));

            return query.Skip(excludedRows).Take(pageSize).AsQueryable();
        }

        public IQueryable<T> GetQueryableMatch(Expression<Func<T, bool>> match, PropertyOrder orderby)
        {
            IQueryable<T> query = GetQueryable(orderby);
            if (match != null)
            {
                query = query.Where(match);
            }
            return query;
        }

        public T GetSigle(Expression<Func<T, bool>> match)
        {
            IQueryable<T> q = GetQueryable(null).Where(match);
            if (q.Count() == 0)
                return null;
            else
                return q.First();
        }

        public T InsertEntity(T entity)
        {
            if (entity != null)
            {
                try
                {
                    T reEntity = this.objectSet.Add(entity);
                    this.baseContext.SaveChanges();
                    return reEntity;
                }

                catch (DbEntityValidationException dbEx)
                {
                    return null;
                }

                catch
                {
                    return null;
                }
            }
            else
                return null;
        }

        public bool DeleteEntity(Expression<Func<T, bool>> match)
        {
            bool result = false;
            IEnumerable<T> existing = GetQueryable(null).Where(match);
            foreach (T entity in existing)
            {
                this.objectSet.Remove(entity);
            }
            result = baseContext.SaveChanges() > 0;
            return result;
        }

        public T GetSingleWithKeys(object key)
        {
            T existing = objectSet.Find(key);
            return existing;
        }

        public bool DeleteEntityWithKeys(object key)
        {
            bool result = false;
            T existing = objectSet.Find(key);
            if (existing != null)
            {
                this.objectSet.Remove(existing);
                result = baseContext.SaveChanges() > 0;
            }
            return result;
        }

        public bool Update(T entity, object key)
        {
            bool result = false;
            T existing = objectSet.Find(key);
            if (existing != null)
            {
                baseContext.Entry(existing).CurrentValues.SetValues(entity);

                result = baseContext.SaveChanges() > 0;
            }
            return result;
        }

        public IList<T> SQLGetListPage(string match, PagerInfo p)
        {
            int currentPage = (p.CurrentPage < 1) ? 1 : p.CurrentPage;
            int pageSize = (p.PageDataCount <= 0) ? 20 : p.PageDataCount;

            int excludedRows = (currentPage - 1) * pageSize;
            var query = baseContext.Set<T>().SqlQuery(match).AsQueryable();

            p.DataCount = query.Count();
            p.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(p.DataCount) / Convert.ToDecimal(p.PageDataCount)));
            return query.Skip(excludedRows).Take(pageSize).ToList();
        }

        public IList<T> SQLGetListMatch(string match)
        {
            return baseContext.Set<T>().SqlQuery(match).ToList();
        }

        public T SQLGetSigle(string match)
        {
            var query = baseContext.Set<T>().SqlQuery(match);
            if (query.Count() == 0)
                return null;
            else
                return query.First();
        }
    }
}
