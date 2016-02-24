using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Common;
using TestUnity.DAL;

namespace TestUnity.BLL
{
    public interface IBaseBLL<T> where T : class
    {
        bool Insert(T entity);
        bool Delete(object id);
        bool Delete(T entity);
        bool Update(T entity, object key);
        T FindByID(object id);
        T FindSingle(Expression<Func<T, bool>> match);
        IQueryable<T> GetQueryable();
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> match, string sortPropertyName, bool isDescending = true);
        ICollection<T> Find(Expression<Func<T, bool>> match);
        ICollection<T> Find<TKey>(Expression<Func<T, bool>> match, Expression<Func<T, TKey>> orderByProperty, bool isDescending = true);
        ICollection<T> FindWithPaper(Expression<Func<T, bool>> match, PagerInfo info);
        ICollection<T> FindWithPager<TKey>(Expression<Func<T, bool>> match, PagerInfo info, Expression<Func<T, TKey>> orderByProperty, bool isDescending = true);
    }
}
