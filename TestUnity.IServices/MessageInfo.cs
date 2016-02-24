using EFWCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWCF.IServices
{
    public class MessageInfo
    {
        public MessageInfo()
        {

        }
        public enum MessageType
        {
            Alert,
            MessageBox,
            FlyoutPanel,
            Bar
        }

        public string MsgTitle { get; set; }
        public string MsgInfo { get; set; }
        public string MsgPublisher { get; set; }
        public ModuleDTO MsgModule { get; set; }
        public System.Windows.Forms.MessageBoxButtons MsgButtons { get; set; }
        public System.Windows.Forms.MessageBoxIcon MsgIco { get; set; }
        public MessageType MsgType { get; set; }
    }
}
