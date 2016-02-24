using EFWCF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace EFWCF.IServices
{
    [ServiceContract]
    public interface IBaseService<dto, entity>
        where dto : DTO.BaseDTO
        where entity : class
    {
        IQueryable<dto> GetQueryable();

        [OperationContract]
        IList<dto> GetList();

        [OperationContract]
        IList<dto> GetListPage(string match, ref PagerInfo p);

        [OperationContract]
        IList<dto> GetListMatch(string match);

        [OperationContract]
        dto GetSigle(string sql);

        [OperationContract]
        dto GetSingleWithKeys(object key);

        [OperationContract]
        dto InsertEntity(dto d);

        //[OperationContract]
        //bool DeleteEntity(string match);

        [OperationContract]
        bool DeleteEntityWithKeys(object key);

        [OperationContract]
        bool Update(dto d, object key);
    }
}
