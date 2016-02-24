using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Models;
namespace TestUnity.DAL
{
    public class ZuZhiJiGouDAL : BaseDAL<ZuZhiJiGous>, IZuZhiJiGouDAL
    {
        BaseContext userContext;
        public ZuZhiJiGouDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
