using System.Collections.Generic;
using EFWCF.Models;
using EFWCF.IServices;
using EFWCF.DTO;
using EFWCF.BLL;
using System.Linq;
namespace EFWCF.Services
{
    public class UserService : ServiceBase<UserDTO, User>, IUserService
    {
        public UserService()
        {
            base.BaseBLL = new UserBLL();
        }

        public UserDTO CanLogin(string uname, string pwd)
        {
            UserBLL bl = new UserBLL();
            User u = bl.GetSigle(e => e.UserName.Equals(uname) && e.UserPwd.Equals(pwd));
            UserDTO userdto = new UserDTO();
            userdto.FetchValuesFromEntity<User>(u);
            return userdto;
        }

        public IList<UserDTO> GetUserList()
        {
            UserBLL bl = new UserBLL();

            IEnumerable<User> lstUser = bl.GetQueryable(null);
            IList<UserDTO> lstU = new List<UserDTO>();
            foreach (User u in lstUser)
            {
                UserDTO udmain = new UserDTO();
                //UserData ud = new UserData();
                //ud.ID = u.ID;
                //ud.EmpName = u.UserEmployee.EmpName;
                //ud.UserName = u.UserName;
                //ud.UserPwd = u.UserPwd;
                udmain.FetchValuesFromEntity<User>(u);
                lstU.Add(udmain);
            }
            return lstU;
        }
    }

    public class EmployeeService : ServiceBase<EmployeeDTO, Employee>, IEmployeeService
    {
        public EmployeeService()
        {
            base.BaseBLL = new EmployeeBLL();
        }
    }

    //public class UserTestService : ServiceBase<UserDTO, User>, IUserTestService
    //{
    //    public UserTestService()
    //    {
    //        base.BaseBLL = new UserBLL();
    //    }

    //    public UserDTO CanLogin(string uname, string pwd)
    //    {
    //        UserBLL bl = new UserBLL();
    //        User u = bl.GetSigle(e => e.UserName.Equals(uname) && e.UserPwd.Equals(pwd));
    //        UserDTO userdto = new UserDTO();
    //        userdto.FetchValuesFromEntity<User>(u);
    //        return userdto;
    //    }

    //    public IList<UserDTO> GetUserList()
    //    {
    //        UserBLL bl = new UserBLL();

    //        IEnumerable<User> lstUser = bl.GetList();
    //        IList<UserDTO> lstU = new List<UserDTO>();
    //        foreach (User u in lstUser)
    //        {
    //            UserDTO udmain = new UserDTO();
    //            //UserData ud = new UserData();
    //            //ud.ID = u.ID;
    //            //ud.EmpName = u.UserEmployee.EmpName;
    //            //ud.UserName = u.UserName;
    //            //ud.UserPwd = u.UserPwd;
    //            udmain.FetchValuesFromEntity<User>(u);
    //            lstU.Add(udmain);
    //        }
    //        return lstU;
    //    }
    //}
}
