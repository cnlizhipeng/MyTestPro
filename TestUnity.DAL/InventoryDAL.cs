using EFWCF.IDAL;
using EFWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.DAL
{
    public class MaterialBaseInfoDAL : BaseDAL<MaterialBaseInfo>, IMaterialBaseInfoDAL
    {
        BaseContext userContext;
        public MaterialBaseInfoDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
