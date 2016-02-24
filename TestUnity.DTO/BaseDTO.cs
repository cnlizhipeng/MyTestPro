using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace EFWCF.DTO
{
    public abstract class BaseDTO
    {
        /// <summary>
        /// 从实体中取得属性值
        /// </summary>
        /// <param name="entity"></param>
        public virtual void FetchValuesFromEntity<TEntity>(TEntity entity)
        {
            Mapper.Map(entity, this, entity.GetType(), this.GetType());
        }

        /// <summary>
        /// 将DTO中的属性值赋值到实体对象中
        /// </summary>
        /// <param name="entity"></param>
        public virtual void AssignValuesToEntity<TEntity>(TEntity entity)
        {
            Mapper.Map(this, entity, this.GetType(), entity.GetType());
        }
    }
}
