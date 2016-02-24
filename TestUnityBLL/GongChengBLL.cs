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
    public class GongChengBLL:BaseBLL<gongchengs>
    {
        IGongChengDAL dal;
        public GongChengBLL()
        {
            dal = base.BaseContainer.Resolve<IGongChengDAL>();
            BaseDAL = dal;
        }
        public GongChengBLL(IGongChengDAL dal)
            : base(dal)
        {
            this.dal = dal;
        }
    }
}
