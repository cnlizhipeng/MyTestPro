using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.IServices
{
    [ServiceContract(CallbackContract = typeof(ISessionCallback))]
    public interface ISessionManagement
    {
        [OperationContract]
        Guid StartSession(SessionClientInfo clientInfo, out TimeSpan timeout);

        [OperationContract(IsOneWay=true)]
        void EndSession(Guid sessionID);

        [OperationContract]
        IList<SessionInfo> GetActiveSessions();

        [OperationContract(IsOneWay = true)]
        void KillSessions(IList<Guid> sessionIDs);

        [OperationContract(IsOneWay=true)]
        void SendMessage(MessageInfo msg,IList<SessionInfo> sessioninfo);
    }
}
