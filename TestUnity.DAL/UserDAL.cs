using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.IDAL;
namespace EFWCF.DAL
{
    public class UserDAL : BaseDAL<EFWCF.Models.User>, IUserDAL
    {
        BaseContext userContext;
        public UserDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }

    public class EmployeeDAL : BaseDAL<EFWCF.Models.Employee>, IEmployeeDAL
    {
        BaseContext userContext;
        public EmployeeDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
