using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;


namespace EFWCF.Models
{
    [Table("SYS_Module")]
    public partial class Module : IModelBase
    {
        public int ID { get; set; }
        public int PID { get; set; }
        [MaxLength(30)]
        [Required]
        public string ModuleCNName { get; set; }
        [MaxLength(20)]
        public string ShortCNName { get; set; }
        [MaxLength(20)]
        public string ModuleENName { get; set; }
        [MaxLength(10)]
        public string ShortENName { get; set; }
        [MaxLength(200)]
        public string ModuleDescribe { get; set; }
        [MaxLength(200)]
        public string ModuleImage { get; set; }
        [MaxLength(50)]
        public string ModuleType { get; set; }
        public bool IsLarge { get; set; }
        [MaxLength(200)]
        public string ControlTypeName { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }
        [Required]
        public int ViewOrder { get; set; }
    }

    [Table("SYS_ModuleTables")]
    public partial class ModuleTables : IModelBase
    {
        [Key]
        public int ID { get; set; }
        public int PID { get; set; }
        [MaxLength(50)]
        public string FieldName { get; set; }
        [MaxLength(50)]
        public string PFieldName { get; set; }
        public int ViewOrder { get; set; }
        public int ModuleID { get; set; }
        public int TableSetID { get; set; }
        [ForeignKey("TableSetID")]
        public virtual TableSet TableSet { get; set; }
        [ForeignKey("ModuleID")]
        public virtual Module Module { get; set; }
    }

    [Table("SYS_TableSet")]
    public partial class TableSet : IModelBase
    {
        public TableSet()
        {
            ColumnSet = new List<ColumnSet>();
        }
        public int ID { get; set; }
        [MaxLength(40)]
        [Required]
        public string TableName { get; set; }
        [MaxLength(40)]
        [Required]
        public string TableCaption { get; set; }
        [MaxLength(100)]
        public string GearedModuleName { get; set; }
        [MaxLength(100)]
        public string ServiceSvcName { get; set; }
        [MaxLength(100)]
        public string ServiceInterface { get; set; }
        [MaxLength(30)]
        public string Binding { get; set; }
        [Display(Description = "是否采用压缩传输数据")]
        public bool GZipTransform { get; set; }
        public virtual IEnumerable<ColumnSet> ColumnSet { get; set; }
    }

    [Table("SYS_ColumnSet")]
    public partial class ColumnSet : IModelBase
    {
        public int ID { get; set; }
        [MaxLength(20)]
        [Required]
        public string FieldName { get; set; }
        [MaxLength(30)]
        [Required]
        public string FieldCap { get; set; }
        [MaxLength(20)]
        [Required]
        public string FieldType { get; set; }
        [Required]
        public int FieldLen1 { get; set; }
        [Required]
        public int FieldLen2 { get; set; }
        [Required]
        public int FieldOrder { get; set; }
        [MaxLength(20)]
        public string FixType { get; set; }
        public bool VisibleEnable { get; set; }
        public bool IsRequired { get; set; }
        public bool CanFilter { get; set; }
        public bool IsReadOnly { get; set; }
        [MaxLength(200)]
        public string PageFooterType { get; set; }
        [MaxLength(200)]
        public string GlobalFooterType { get; set; }
        public int TableID { get; set; }
        [ForeignKey("TableID")]
        public virtual TableSet TableSet { get; set; }
    }

    [Table("SYS_FunctionSet")]
    public partial class FunctionSet : IModelBase
    {
        public int ID { get; set; }
        public bool UseEnable { get; set; }
        public bool VisibleEnable { get; set; }
        public bool AddEnable { get; set; }
        public bool EditEnable { get; set; }
        public bool DeleteEnable { get; set; }
    }
    [Table("SYS_MenuSet")]
    public partial class MenuSet : IModelBase
    {
        public int ID { get; set; }
        public int PID { get; set; }
        [MaxLength(50)]
        [Required]
        public string MenuType { get; set; }
        [MaxLength(50)]
        [Required]
        public string MenuCaption { get; set; }
        [MaxLength(50)]
        public string MenuImage { get; set; }
        [MaxLength(200)]
        public string EventName { get; set; }
        [MaxLength(200)]
        public string EventParameter { get; set; }
        public int ViewOrder { get; set; }
        public bool BeginGroup { get; set; }
    }
    [Table("SYS_ModuleMenu")]
    public partial class ModuleMenu : IModelBase
    {
        public int ID { get; set; }
        public int MenuSetPID { get; set; }
        public string MenuType { get; set; }
        public string MenuCaption { get; set; }
        public string MenuImage { get; set; }
        public string EventName { get; set; }
        public string EventParameter { get; set; }
        public int ViewOrder { get; set; }
        public bool BeginGroup { get; set; }
        public int ModuleID { get; set; }
        public int MenuSetID { get; set; }
        [ForeignKey("MenuSetID")]
        public virtual MenuSet MenuSet { get; set; }
        [ForeignKey("ModuleID")]
        public virtual Module Module { get; set; }
    }
    [Table("SYS_ModuleColumn")]
    public partial class ModuleColumn : IModelBase
    {
        public int ID { get; set; }
        [Required]
        public int FieldOrder { get; set; }
        public bool VisibleEnable { get; set; }
        public string PageFooterType { get; set; }
        public string GlobalFooterType { get; set; }

        public int ModuleID { get; set; }
        public int ColumnSetID { get; set; }
        [ForeignKey("ColumnSetID")]
        public virtual ColumnSet ColumnSet { get; set; }
        [ForeignKey("ModuleID")]
        public virtual Module Module { get; set; }
    }

    [Table("SYS_DesktopLink")]
    public partial class DesktopLink : IModelBase
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        [ForeignKey("ModuleID")]
        public virtual Module Module { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
