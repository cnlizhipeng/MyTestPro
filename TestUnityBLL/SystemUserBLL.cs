using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Models;
using Microsoft.Practices.Unity;
using TestUnity.DAL;
namespace TestUnity.BLL
{
    public class SystemUserBLL : BaseBLL<SystemUsers>
    {
        ISystemUserDAL dal;
        public SystemUserBLL()
        {
            dal = base.BaseContainer.Resolve<ISystemUserDAL>();
            BaseDAL = dal;
        }
        public SystemUserBLL(ISystemUserDAL dal)
            : base(dal)
        {
            this.dal = dal;
        }
    }
}
