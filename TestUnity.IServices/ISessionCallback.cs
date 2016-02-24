using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.IServices
{
    [ServiceContract]
    public interface ISessionCallback
    {
        [OperationContract]
        TimeSpan Renew();

        [OperationContract(IsOneWay = true)]
        void OnSessionKilled(SessionInfo sessionInfo);

        [OperationContract(IsOneWay = true)]
        void OnSessionTimeout(SessionInfo sessionInfo);

        [OperationContract(IsOneWay = true)]
        void MessageShow(MessageInfo msginfo);
    }
}
