using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.DAL;
using TestUnity.Models;
using Microsoft.Practices.Unity;
namespace TestUnity.BLL
{
    public class ZuZhiJiGouBLL : BaseBLL<ZuZhiJiGous>
    {
        IZuZhiJiGouDAL dal;
        public ZuZhiJiGouBLL()
        {
            dal = base.BaseContainer.Resolve<IZuZhiJiGouDAL>();
            BaseDAL = dal;
        }
        public ZuZhiJiGouBLL(IZuZhiJiGouDAL dal)
            : base(dal)
        {
            this.dal = dal;
        }
    }
}
