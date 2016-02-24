using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Models;
using System.Data.Entity;
namespace TestUnity.DAL
{
    public class SystemUserDAL : BaseDAL<SystemUsers>, ISystemUserDAL
    {
        BaseContext userContext;
        public SystemUserDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
