using EFWCF.IServices;
using EFWCF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFWCF.WebWCF.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendMsg_Click(object sender, EventArgs e)
        {
           IDictionary<Guid,ISessionCallback>dic = SessionManager.CurrentCallbackList;
           if (dic != null)
           {
                MessageInfo mi = new MessageInfo();
               mi.MsgTitle="标题";
               mi.MsgInfo="内容";
               mi.MsgIco= System.Windows.Forms.MessageBoxIcon.Information;
               mi.MsgButtons= System.Windows.Forms.MessageBoxButtons.OKCancel;
               mi.MsgType= MessageInfo.MessageType.Alert;
               foreach (KeyValuePair<System.Guid, ISessionCallback> kvp in dic)
               {
                   try
                   {
                       kvp.Value.MessageShow(mi);
                   }
                   catch
                   { 
                   }

               }
           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = SessionManager.CurrentSessionList.Values.ToList();
        }
    }
}