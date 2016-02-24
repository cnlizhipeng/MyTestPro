using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using EFWCF.IDAL;
using EFWCF.IBLL;
using EFWCF.Models;
namespace EFWCF.BLL
{
    public class UserBLL : BaseBLL<User>, IUserBLL
    {
        IUserDAL dal;
        public UserBLL()
        {
            dal = base.BaseContainer.Resolve<IUserDAL>();
            base.BaseDAL = dal;
        }

        public UserBLL(IUserDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }

    public class EmployeeBLL : BaseBLL<Employee>
    {
        IEmployeeDAL dal;
        public EmployeeBLL()
        {
            dal = base.BaseContainer.Resolve<IEmployeeDAL>();
            base.BaseDAL = dal;
        }

        public EmployeeBLL(IEmployeeDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
}
