using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EFWCF.IServices
{
    [ServiceContract(CallbackContract = typeof(IUpLoadCallback))]
    public interface IFileService
    {
        [OperationContract]
        void GetFile(UpLoadFileInfo ufi);
        [OperationContract]
        bool UpLoadFile(UpLoadFileInfo ufi);
        [OperationContract]
        IEnumerable<UpLoadFileInfo> GetUpdateList(string version,Guid clientguid);
    }
}
