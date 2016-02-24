using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IServices;
using EFWCF.Models;
namespace EFWCF.Services
{
    public abstract class BaseService<dto, entity> : IBaseService<dto, entity>
        where dto : DTO.BaseDTO, new()
        where entity : class,IModelBase, new()
    {
        public EFWCF.IBLL.IBaseBLL<entity> BaseBLL { get; set; }

        public virtual IQueryable<dto> GetQueryable()
        {
            List<dto> lstDto = new List<dto>();

            IQueryable<entity> q = this.BaseBLL.GetQueryable();
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto.AsQueryable();
        }

        public virtual IList<dto> GetList()
        {
            List<dto> lstDto = new List<dto>();
            IEnumerable<entity> q = this.BaseBLL.GetQueryable().ToList();
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IEnumerable<dto> GetEnumerable()
        {
            List<dto> lstDto = new List<dto>();

            IQueryable<entity> q = this.BaseBLL.GetQueryable();
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IQueryable<dto> GetQueryablePage(System.Linq.Expressions.Expression<Func<entity, bool>> match, Common.PagerInfo p)
        {
            List<dto> lstDto = new List<dto>();

            IQueryable<entity> q = this.BaseBLL.GetQueryablePage(match, p);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto.AsQueryable();
        }

        public virtual IList<dto> GetListPage(System.Linq.Expressions.Expression<Func<entity, bool>> match, Common.PagerInfo p)
        {
            List<dto> lstDto = new List<dto>();

            IList<entity> q = this.BaseBLL.GetListPage(match, p);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IEnumerable<dto> GetEnumerablePage(System.Linq.Expressions.Expression<Func<entity, bool>> match, Common.PagerInfo p)
        {
            List<dto> lstDto = new List<dto>();

            IEnumerable<entity> q = this.BaseBLL.GetEnumerablePage(match, p);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IQueryable<dto> GetQueryableMatch(System.Linq.Expressions.Expression<Func<entity, bool>> match)
        {
            List<dto> lstDto = new List<dto>();

            IQueryable<entity> q = this.BaseBLL.GetQueryableMatch(match);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto.AsQueryable();
        }

        public virtual IList<dto> GetListMatch(System.Linq.Expressions.Expression<Func<entity, bool>> match)
        {
            List<dto> lstDto = new List<dto>();

            IList<entity> q = this.BaseBLL.GetListMatch(match);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IEnumerable<dto> GetEnumerableMatch(System.Linq.Expressions.Expression<Func<entity, bool>> match)
        {
            List<dto> lstDto = new List<dto>();

            IEnumerable<entity> q = this.BaseBLL.GetEnumerableMatch(match);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual dto GetSigle(System.Linq.Expressions.Expression<Func<entity, bool>> match)
        {
            dto addDto = new dto();

            entity q = this.BaseBLL.GetSigle(match);
            addDto.FetchValuesFromEntity<entity>(q);
            return addDto;
        }

        public virtual dto GetSingleWithKeys(object key)
        {
            dto addDto = new dto();

            entity q = this.BaseBLL.GetSingleWithKeys(key);
            addDto.FetchValuesFromEntity<entity>(q);
            return addDto;
        }

        public virtual dto InsertEntity(dto d)
        {
            entity e = new entity();
            d.AssignValuesToEntity<entity>(e);
            entity addE = this.BaseBLL.InsertEntity(e);
            if (addE != null)
            {
                d.FetchValuesFromEntity<entity>(addE);
                return d;
            }
            else
                return null;
        }

        public virtual bool DeleteEntity(System.Linq.Expressions.Expression<Func<entity, bool>> match)
        {
            return this.BaseBLL.DeleteEntity(match);
        }

        public virtual bool DeleteEntityWithKeys(object key)
        {
            return this.BaseBLL.DeleteEntityWithKeys(key);
        }

        public virtual bool Update(dto d, object key)
        {
            entity e = new entity();
            d.AssignValuesToEntity<entity>(e);
            return this.BaseBLL.Update(e, key);
        }

        public virtual IList<dto> GetListPage(string match,ref Common.PagerInfo p)
        {
            List<dto> lstDto = new List<dto>();

            IEnumerable<entity> q = this.BaseBLL.SQLGetListPage(match, p);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual IList<dto> GetListMatch(string match)
        {
            List<dto> lstDto = new List<dto>();

            IEnumerable<entity> q = this.BaseBLL.SQLGetListMatch(match);
            foreach (entity et in q)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(et);
                lstDto.Add(addDto);
            }
            return lstDto;
        }

        public virtual dto GetSigle(string sql)
        {
            entity q = this.BaseBLL.SQLGetSigle(sql);
            if (q != null)
            {
                dto addDto = new dto();
                addDto.FetchValuesFromEntity<entity>(q);
                return addDto;
            }
            else
                return null;
        }
    }
}
