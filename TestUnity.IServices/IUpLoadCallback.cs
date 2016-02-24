using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace EFWCF.IServices
{
    [ServiceContract]
    public interface IUpLoadCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReciveFileByte(byte[] body);
    }
}
