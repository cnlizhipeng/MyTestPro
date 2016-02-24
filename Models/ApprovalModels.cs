using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFWCF.Models
{
    [Table("SYS_ApprovalSubmitInfo")]
    public class ApprovalSubmitInfo : IModelBase
    {
        public int ID { get; set; }
        public int RecordID { get; set; }
        public string TableName { get; set; }
        public DateTime SubmitTime { get; set; }
        public DateTime VetoOrApprovalTime { get; set; }
        public string SpendTime { get; set; }
        public string LastType { get; set; }
    }
    [Table("SYS_ApprovalDetails")]
    public class ApprovalDetails : IModelBase
    {
        [Key]
        public int ID { get; set; }
        public int PID { get; set; }
        public int ApprovalStep { get; set; }
        public int ApprovalGroup { get; set; }
        public int ApprovalGroupStep { get; set; }
        public int EmployeeID { get; set; }
        public int ApprovalSubmitInfoID { get; set; }
        [MaxLength(50)]
        [Display(Description = "同组执行模式：一票否决、单票通过、全部通过")]
        public string GroupApprType { get; set; }
        public DateTime VetoOrApprovalTime { get; set; }
        [MaxLength(100)]
        public string SpendTime { get; set; }
        [MaxLength(100)]
        public string LastType { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("ApprovalSubmitInfoID")]
        public virtual ApprovalSubmitInfo ApprovalSubmitInfo { get; set; }
    }
    [Table("SYS_ApprovalProcess")]
    public class ApprovalProcess : IModelBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProcessName { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }
    }
    [Table("SYS_ApprovalProcess")]
    public class ProcessStep : IModelBase
    {
        public int ID { get; set; }
        public int ApprovalProcessID { get; set; }
        [Required]
        [MaxLength(50)]
        public string StepName { get; set; }
        [Display(Description = "同组执行模式：多选中一票否决、单票通过、全部通过，或者多选一")]
        [Required]
        [MaxLength(50)]
        public string InfoType { get; set; }
        [ForeignKey("ApprovalProcessID")]
        public virtual ApprovalProcess ApprovalProcess { get; set; }
    }
    [Table("SYS_ApprovalProcess")]
    public class ProcessStepInfo : IModelBase
    {
        public int ID { get; set; }
        public int ProcessStepID { get; set; }

        [ForeignKey("ProcessStepID")]
        public virtual ProcessStep ProcessStep { get; set; }
    }
}
