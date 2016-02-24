using EFWCF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
namespace EFWCF.IBLL
{
    public interface IBaseBLL<T> where T : class,IModelBase
    {
        IEnumerable<T> GetQueryable(PropertyOrder orderby);

        IEnumerable<T> GetQueryablePage(Expression<Func<T, bool>> match, PagerInfo p, PropertyOrder orderby);

        IEnumerable<T> GetQueryableMatch(Expression<Func<T, bool>> match, PropertyOrder orderby);

        T GetSigle(Expression<Func<T, bool>> match);

        T GetSingleWithKeys(object key);

        T InsertEntity(T entity);

        bool DeleteEntity(Expression<Func<T, bool>> match);

        bool DeleteEntityWithKeys(object key);

        bool Update(T entity, object key);

        IList<T> SQLGetListPage(string match, PagerInfo p);

        IList<T> SQLGetListMatch(string match);

        T SQLGetSigle(string match);
    }
}
