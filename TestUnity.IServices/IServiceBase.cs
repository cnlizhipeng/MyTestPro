using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EFWCF.DTO;
using EFWCF.Common;

namespace EFWCF.IServices
{
    [ServiceContract]
    public interface IServiceBase<T> where T : BaseDTO, new()
    {
        [OperationContract]
        IList<T> GetList(PropertyOrder orderby);

        [OperationContract]
        IList<T> GetListPage(IEnumerable<PropertyMatch> match, ref PagerInfo p,PropertyOrder orderby);

        [OperationContract]
        IList<T> GetListMatch(IEnumerable<PropertyMatch> match, PropertyOrder orderby);

        [OperationContract]
        T GetSigle(IEnumerable<PropertyMatch> match);

        [OperationContract]
        T GetSingleWithKeys(object key);

        [OperationContract]
        T InsertEntity(T d);

        //[OperationContract]
        //bool DeleteEntity(string match);

        [OperationContract]
        bool DeleteEntityWithKeys(object key);

        [OperationContract]
        bool Update(T d, object key);
    }
}
