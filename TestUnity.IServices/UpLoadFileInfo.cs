using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace EFWCF.IServices
{
    [DataContract]
    public class UpLoadFileInfo
    {
        public enum OperationType
        {
            Update,//更新
            DownLoad,//下载   
            UpLoad//上传
        }
        public enum FileType
        {
            excel,
            word,
            rar,
            orther
        }
        [DataMember]
        public Guid ClientID { get; set; }
        [DataMember]
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件在服务器的位置
        /// </summary>
        public string FileServerPath { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件在客户端更新位置
        /// </summary>
        public string FileClienPath { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件主体
        /// </summary>
        public byte[] FileByte { get; private set; }
        [DataMember]
        /// <summary>
        /// 操作类型
        /// </summary>
        public OperationType Operration { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件类型
        /// </summary>
        public FileType FilesType { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件版本号
        /// </summary>
        public string FileVer { get; private set; }
        [DataMember]
        /// <summary>
        /// 一些说明信息
        /// </summary>
        public string Remarks { get; private set; }
        [DataMember]
        /// <summary>
        /// 文件大小
        /// </summary>
        public long ByteLenth { get; set; }

        /// <summary>
        /// 系统更新初始化
        /// </summary>
        /// <param name="ft">文件类型</param>
        /// <param name="filename">文件名称</param>
        /// <param name="filecp">客户端存储路径</param>
        /// <param name="fv">文件版本</param>
        /// <param name="remark">备注</param>
        /// <param name="body">文件内容</param>
        public UpLoadFileInfo(Guid clientguid, FileType ft, string filename, string filecp, string fv, string remark, byte[] body)
        {
            ClientID = clientguid;
            Operration = OperationType.Update;
            FilesType = ft;
            FileName = filename;
            FileClienPath = filecp;
            FileVer = fv;
            Remarks = remark;
            FileByte = body;
            FileStream fi = File.Open(AppDomain.CurrentDomain.BaseDirectory + "/aaa.rar", FileMode.Open, FileAccess.Read, FileShare.Read);
            ByteLenth = fi.Length;
        }

        /// <summary>
        /// 服务器上传下载文件
        /// </summary>
        /// <param name="ot">操作类型</param>
        /// <param name="ft">文件类型</param>
        /// <param name="filename">文件名</param>
        /// <param name="filecp">客户端存储路径</param>
        /// <param name="remark">备注</param>
        /// <param name="body">文件内容</param>
        public UpLoadFileInfo(Guid clientguid, OperationType op, FileType ft, string filename, string filecp, string remark, byte[] body)
        {
            ClientID = clientguid;
            Operration = op;
            FilesType = ft;
            FileName = filename;
            FileClienPath = filecp;
            Remarks = remark;
            FileByte = body;
        }
    }
}
