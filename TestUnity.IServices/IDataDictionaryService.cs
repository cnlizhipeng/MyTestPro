using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.DTO;
using System.ServiceModel;
namespace EFWCF.IServices
{
    [ServiceContract]
    public interface IDataDictionaryService : IServiceBase<DataDictionaryDTO>
    {
    }
}
