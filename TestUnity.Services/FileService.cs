using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IServices;
using System.IO;
using System.ServiceModel;


namespace EFWCF.Services
{
    public class FileService : EFWCF.IServices.IFileService
    {
        object syncobj = new object();
        /// <summary>
        /// 与客户端通信，终止客户端连接等内容
        /// </summary>
        public static IDictionary<Guid, IUpLoadCallback> CurrentCallbackList
        { get; set; }
        static FileService()
        {
            CurrentCallbackList = new Dictionary<Guid, IUpLoadCallback>();
        }
        public void GetFile(IServices.UpLoadFileInfo ufi)
        {
            FileStream fs = File.Open(AppDomain.CurrentDomain.BaseDirectory + "/aaa.rar", FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] buffer = new byte[1024];
            int bytesRead;
            while (true)
            {
                bytesRead = fs.Read(buffer, 0, buffer.Length);
                IUpLoadCallback ic =  OperationContext.Current.GetCallbackChannel<IUpLoadCallback>();
                ic.ReciveFileByte(buffer);
                if (bytesRead == 0)
                    break;
            }
        }

        public bool UpLoadFile(IServices.UpLoadFileInfo ufi)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<UpLoadFileInfo> GetUpdateList(string version, Guid clientguid)
        {
            //IUpLoadCallback cb = OperationContext.Current.GetCallbackChannel<IUpLoadCallback>();
            //if (!CurrentCallbackList.ContainsKey(clientguid))
            //    CurrentCallbackList.Add(clientguid, cb);
            UpLoadFileInfo[] uf = new UpLoadFileInfo[] { 
                new UpLoadFileInfo(clientguid, UpLoadFileInfo.FileType.orther,"文件1","","","备注信息",null),
                new UpLoadFileInfo(clientguid, UpLoadFileInfo.FileType.orther,"文件2","","","备注信息",null)
            };
            return uf;
        }
    }
}
