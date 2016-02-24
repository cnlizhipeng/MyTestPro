using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IServices;
using System.ServiceModel;
namespace EFWCF.Services
{
    public class SessionManagementService : ISessionManagement
    {
        #region ISessionManagement Members

        public Guid StartSession(SessionClientInfo clientInfo, out TimeSpan timeout)
        {
            timeout = SessionManager.Timeout;
            return SessionManager.StartSession(clientInfo);
        }

        public void EndSession(Guid sessionID)
        {
            SessionManager.EndSession(sessionID);
        }

        public IList<SessionInfo> GetActiveSessions()
        {
            return new List<SessionInfo>(SessionManager.CurrentSessionList.Values.ToArray<SessionInfo>());
        }

        public void KillSessions(IList<Guid> sessionIDs)
        {
            SessionManager.KillSessions(sessionIDs);
        }

        #endregion

        public void SendMessage(MessageInfo msg, IList<SessionInfo> sessioninfo)
        {
            var q = from s in SessionManager.CurrentCallbackList
                    where sessioninfo.Where(e => e.SessionID == s.Key).Count() > 0
                    select s;
            foreach (KeyValuePair<Guid, ISessionCallback> val in q)
            {
                val.Value.MessageShow(msg);
            }
        }
    }
}
