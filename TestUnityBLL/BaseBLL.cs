using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.Practices.Unity;
using TestUnity.DAL;
using System.Linq.Expressions;
using TestUnity.Common;

namespace TestUnity.BLL
{
    public abstract class BaseBLL<T> : IBaseBLL<T> where T : class
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

        public BaseBLL(IBaseDAL<T> dal)
        {
            this.BaseDAL = dal;
        }

        public virtual bool Insert(T entity)
        {
            return BaseDAL.Insert(entity);
        }

        public virtual bool Delete(object id)
        {
            return BaseDAL.Delete(id);
        }

        public virtual bool Delete(T entity)
        {
            return BaseDAL.Delete(entity);
        }

        public virtual bool Update(T entity, object key)
        {
            return BaseDAL.Update(entity, key);
        }

        public virtual T FindByID(object id)
        {
            return BaseDAL.FindByID(id);
        }

        public virtual T FindSingle(Expression<Func<T, bool>> match)
        {
            return BaseDAL.FindSingle(match);
        }

        public virtual IQueryable<T> GetQueryable()
        {
            return BaseDAL.GetQueryable();
        }

        public virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> match, string sortPropertyName, bool isDescending = true)
        {
            return BaseDAL.GetQueryable(match, sortPropertyName, isDescending);
        }

        public virtual ICollection<T> Find(Expression<Func<T, bool>> match)
        {
            return BaseDAL.Find(match);
        }

        public virtual ICollection<T> Find<TKey>(Expression<Func<T, bool>> match, Expression<Func<T, TKey>> orderByProperty, bool isDescending = true)
        {
            return BaseDAL.Find<TKey>(match, orderByProperty, isDescending);
        }

        public virtual ICollection<T> FindWithPaper(Expression<Func<T, bool>> match, PagerInfo info)
        {
            return BaseDAL.FindWithPaper(match, info);
        }

        public virtual ICollection<T> FindWithPager<TKey>(Expression<Func<T, bool>> match, PagerInfo info, Expression<Func<T, TKey>> orderByProperty, bool isDescending = true)
        {
            return BaseDAL.FindWithPager<TKey>(match, info, orderByProperty, isDescending);
        }
    }
}
