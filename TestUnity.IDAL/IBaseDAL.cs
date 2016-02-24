using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using EFWCF.Common;
using EFWCF.Models;

namespace EFWCF.IDAL
{
    public interface IBaseDAL<T> where T : class,IModelBase
    {
        IQueryable<T> GetQueryable(PropertyOrder orderby);

        IQueryable<T> GetQueryablePage(Expression<Func<T, bool>> match, PagerInfo p, PropertyOrder orderby);

        IQueryable<T> GetQueryableMatch(Expression<Func<T, bool>> match, PropertyOrder orderby);

        T GetSigle(Expression<Func<T, bool>> match);

        T GetSingleWithKeys(object key);

        T InsertEntity(T entity);

        bool DeleteEntity(Expression<Func<T, bool>> match);

        bool DeleteEntityWithKeys(object key);

        bool Update(T entity,object key);

        IList<T> SQLGetListPage(string match, PagerInfo p);

        IList<T> SQLGetListMatch(string match);

        T SQLGetSigle(string match);
    }
}
