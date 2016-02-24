using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.DTO
{
    public partial class ModuleDTO : BaseDTO
    {
        //public ModuleDTO()
        //{
        //    TableSet = new List<ModuleTablesDTO>();
        //}
        public int ID { get; set; }
        public int PID { get; set; }
        public string ModuleCNName { get; set; }
        public string ShortCNName { get; set; }
        public string ModuleENName { get; set; }
        public string ShortENName { get; set; }
        public string ModuleDescribe { get; set; }
        public string ModuleImage { get; set; }
        public string ModuleType { get; set; }
        public string ControlTypeName { get; set; }
        public string Remarks { get; set; }
        public int ViewOrder { get; set; }
        public bool IsLarge { get; set; }
        public List<ModuleTablesDTO> TableSet { get; set; }
    }


    public partial class ModuleTablesDTO : BaseDTO
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public string TableSetTableName { get; set; }
        public string TableSetTableCaption { get; set; }
        public string FieldName { get; set; }
        public string PFieldName { get; set; }
        public int ViewOrder { get; set; }
        public int ModuleID { get; set; }
        public int TableSetID { get; set; }
        public TableSetDTO TableSet { get; set; }
    }

    public partial class TableSetDTO : BaseDTO
    {
        public TableSetDTO()
        {
            ColumnSet = new List<ColumnSetDTO>();
        }
        public int ID { get; set; }
        public string TableName { get; set; }
        public string TableCaption { get; set; }
        public string GearedModuleName { get; set; }
        public string ServiceSvcName { get; set; }
        public string ServiceInterface { get; set; }
        public string Binding { get; set; }
        public bool GZipTransform { get; set; }
        public IEnumerable<ColumnSetDTO> ColumnSet { get; set; }
    }

    public partial class ColumnSetDTO : BaseDTO
    {
        public int ID { get; set; }
        public string FieldName { get; set; }
        public string FieldCap { get; set; }
        public string FieldType { get; set; }
        public int FieldLen1 { get; set; }
        public int FieldLen2 { get; set; }
        public int FieldOrder { get; set; }
        public bool VisibleEnable { get; set; }
        public string FixType { get; set; }
        public bool IsRequired { get; set; }
        public bool CanFilter { get; set; }
        public bool IsReadOnly { get; set; }
        public string PageFooterType { get; set; }
        public string GlobalFooterType { get; set; }
        public int TableID { get; set; }
        public TableSetDTO TableSet { get; set; }
    }

    public partial class FunctionSetDTO : BaseDTO
    {
        public int ID { get; set; }
        public bool UseEnable { get; set; }
        public bool VisibleEnable { get; set; }
        public bool AddEnable { get; set; }
        public bool EditEnable { get; set; }
        public bool DeleteEnable { get; set; }
    }

    public partial class MenuSetDTO : BaseDTO
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public string MenuType { get; set; }
        public string MenuCaption { get; set; }
        public string MenuImage { get; set; }
        public string EventName { get; set; }
        public string EventParameter { get; set; }
        public int ViewOrder { get; set; }
        public bool BeginGroup { get; set; }
    }

    public partial class ModuleMenuDTO : BaseDTO
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
        public int MenuSetID { get; set; }
        public int ModuleID { get; set; }
        public virtual MenuSetDTO MenuSet { get; set; }
        public virtual ModuleDTO Module { get; set; }
    }

    public partial class ModuleColumnDTO:BaseDTO
    {
        public int ID { get; set; }
        public string FieldName { get; set; }
        public string FieldCap { get; set; }
        public string FieldType { get; set; }
        public int FieldLen1 { get; set; }
        public int FieldLen2 { get; set; }

        public int FieldOrder { get; set; }
        public bool VisibleEnable { get; set; }
        public string PageFooterType { get; set; }
        public string GlobalFooterType { get; set; }

        public int TableSetID { get; set; }
        public int ColumnSetID { get; set; }
        public int ModuleID { get; set; }
        public virtual ColumnSetDTO MenuSet { get; set; }
        public virtual ModuleDTO Module { get; set; }
        public virtual TableSetDTO TableSet { get; set; }
    }

    public partial class DesktopLinkDTO : BaseDTO
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public virtual ModuleDTO Module { get; set; }
        public int UserID { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
