//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFWCF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    [Table("SYS_User")]
    public partial class User : IModelBase
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
    }

    [Table("HR_Employee")]
    public partial class Employee : IModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(2)]
        public string Sex { get; set; }
        [Column("UPhoto", TypeName = "image")]
        public byte[] UPhoto { get; set; }
        public Nullable<int> Age { get; set; }
        public Guid RowGuid { get; set; }
        public Nullable<int> OrganizationID { get; set; }
    }
    [Table("SYS_Role")]
    public class Role : IModelBase
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }

    }
    [Table("SYS_UserRole")]
    public class UserRole : IModelBase
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
    [Table("SYS_RoleModule")]
    public class RoleModule : IModelBase
    {
        public int ID { get; set; }
        public bool CanVisible { get; set; }
        public bool CanUserMenu { get; set; }
        public int ModuleID { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role Role { get; set; }
        [ForeignKey("ModuleID")]
        public Module Module { get; set; }
    }
}
