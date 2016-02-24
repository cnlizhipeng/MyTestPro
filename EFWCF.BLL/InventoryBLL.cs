using EFWCF.IDAL;
using EFWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace EFWCF.BLL
{
    public class MaterialBaseInfoBLL : BaseBLL<MaterialBaseInfo>
    {
        IMaterialBaseInfoDAL dal;
        public MaterialBaseInfoBLL()
        {
            dal = base.BaseContainer.Resolve<IMaterialBaseInfoDAL>();
            base.BaseDAL = dal;
        }

        public MaterialBaseInfoBLL(IMaterialBaseInfoDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
}
