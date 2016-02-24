using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFWCF.Models;
namespace EFWCF.DTO
{
    public class UserDTO : BaseDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public byte[] EmployeeUPhoto { get; set; }
        public EmployeeDTO Employee { get; set; }
    }
    public partial class EmployeeDTO : BaseDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public byte[] UPhoto { get; set; }
        public Nullable<int> Age { get; set; }
        public Guid RowGuid { get; set; }
        public Nullable<int> OrganizationID { get; set; }
    }
    public class RoleDTO : BaseDTO
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string Remarks { get; set; }

    }
    public class UserRoleDTO : BaseDTO
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
    }
    public class RoleModuleDTO : BaseDTO
    {
        public int ID { get; set; }
        public bool CanVisible { get; set; }
        public bool CanUserMenu { get; set; }
        public int ModuleID { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public Module Module { get; set; }
    }
}
