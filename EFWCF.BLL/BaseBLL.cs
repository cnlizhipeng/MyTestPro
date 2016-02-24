using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IBLL;
using EFWCF.IDAL;
using Microsoft.Practices.Unity;
using System.Linq.Expressions;
using EFWCF.Common;
using EFWCF.Models;
namespace EFWCF.BLL
{
    public class BaseBLL<T> : IBaseBLL<T> where T : class,IModelBase
    {
        protected object syncObject = new object();

        protected IBaseDAL<T> BaseDAL { get; set; }
        protected IUnityContainer BaseContainer { get; set; }

        public BaseBLL()
        {
            lock (syncObject)
            {
                BaseContainer = FactoryDAL.Instance.Container;
                if (BaseContainer == null)
                {
                    throw new ArgumentNullException("container", "container没有初始化");
                }
            }
        }

        public IEnumerable<T> GetQueryable(PropertyOrder orderby)
        {
            return BaseDAL.GetQueryable(orderby).ToList();
        }

        public IEnumerable<T> GetQueryablePage(Expression<Func<T, bool>> match, PagerInfo p, PropertyOrder orderby)
        {
            return BaseDAL.GetQueryablePage(match, p, orderby).ToList();
        }

        public IEnumerable<T> GetQueryableMatch(Expression<Func<T, bool>> match, PropertyOrder orderby)
        {
            return BaseDAL.GetQueryableMatch(match, orderby).ToList();
        }

        public T GetSigle(Expression<Func<T, bool>> match)
        {
            return BaseDAL.GetSigle(match);
        }

        public T GetSingleWithKeys(object key)
        {
            return BaseDAL.GetSingleWithKeys(key);
        }

        public T InsertEntity(T entity)
        {
            return BaseDAL.InsertEntity(entity);
        }

        public bool DeleteEntity(Expression<Func<T, bool>> match)
        {
            return BaseDAL.DeleteEntity(match);
        }

        public bool DeleteEntityWithKeys(object key)
        {
            return BaseDAL.DeleteEntityWithKeys(key);
        }

        public bool Update(T entity, object key)
        {
            return BaseDAL.Update(entity, key);
        }

        public IList<T> SQLGetListPage(string match, PagerInfo p)
        {
            return BaseDAL.SQLGetListPage(match, p);
        }

        public IList<T> SQLGetListMatch(string match)
        {
            return BaseDAL.SQLGetListMatch(match);
        }

        public T SQLGetSigle(string match)
        {
            return BaseDAL.SQLGetSigle(match);
        }
    }
}
