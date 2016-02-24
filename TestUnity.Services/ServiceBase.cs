using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IServices;
using EFWCF.IBLL;
using EFWCF.DTO;
using EFWCF.Models;
using Microsoft.Practices.Unity;
using EFWCF.Common;
namespace EFWCF.Services
{
    public class ServiceBase<T, M> : IServiceBase<T>
        where T : BaseDTO, new()
        where M : class,IModelBase, new()
    {
        protected object syncObject = new object();
        protected IBaseBLL<M> BaseBLL { get; set; }
        //反射减少Service与BLL层之间的耦合
        //protected IUnityContainer ServiceBaseContainer { get; set; }

        //public ServiceBase()
        //{
        //    lock (syncObject)
        //    {
        //        ServiceBaseContainer = ServiceUnityFactory.Instance.Container;
        //        if (ServiceBaseContainer == null)
        //        {
        //            throw new ArgumentNullException("container", "BLLContainer没有初始化");
        //        }
        //    }
        //}

        

        #region 服务方法
        public IList<T> GetList(PropertyOrder orderby)
        {
            List<T> lstDto = new List<T>();
            IEnumerable<M> q = this.BaseBLL.GetQueryable(orderby).ToList();
            foreach (M et in q)
            {
                T addDto = new T();
                addDto.FetchValuesFromEntity<M>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public IList<T> GetListMatch(IEnumerable<PropertyMatch> match, PropertyOrder orderby)
        {
            List<T> lstDto = new List<T>();
            Expression<Func<M, bool>> realmatch = LinqExpressionMatch<M>.GetExpressionFromString(match);
            IEnumerable<M> q = this.BaseBLL.GetQueryableMatch(realmatch, orderby).ToList();
            foreach (M et in q)
            {
                T addDto = new T();
                addDto.FetchValuesFromEntity<M>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IList<T> GetListPage(IEnumerable<PropertyMatch> match, ref PagerInfo p, PropertyOrder orderby)
        {
            List<T> lstDto = new List<T>();
            Expression<Func<M, bool>> realmatch = LinqExpressionMatch<M>.GetExpressionFromString(match);
            IEnumerable<M> q = this.BaseBLL.GetQueryablePage(realmatch, p, orderby).ToList();
            foreach (M et in q)
            {
                T addDto = new T();
                addDto.FetchValuesFromEntity<M>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual T GetSigle(IEnumerable<PropertyMatch> match)
        {
            Expression<Func<M, bool>> realMatch = LinqExpressionMatch<M>.GetExpressionFromString(match);
            M q = this.BaseBLL.GetSigle(realMatch);
            if (q != null)
            {
                T addDto = new T();
                addDto.FetchValuesFromEntity<M>(q);
                return addDto;
            }
            else
                return null;
        }

        public virtual T GetSingleWithKeys(object key)
        {
            T addDto = new T();

            M q = this.BaseBLL.GetSingleWithKeys(key);
            addDto.FetchValuesFromEntity<M>(q);
            return addDto;
        }

        public virtual T InsertEntity(T d)
        {
            M e = new M();
            d.AssignValuesToEntity<M>(e);
            M addE = this.BaseBLL.InsertEntity(e);
            if (addE != null)
            {
                d.FetchValuesFromEntity<M>(addE);
                return d;
            }
            else
                return null;
        }

        public virtual bool DeleteEntityWithKeys(object key)
        {
            return this.BaseBLL.DeleteEntityWithKeys(key);
        }

        public virtual bool Update(T d, object key)
        {
            M e = new M();
            d.AssignValuesToEntity<M>(e);
            return this.BaseBLL.Update(e, key);
        }
        #endregion

    
    }
}
