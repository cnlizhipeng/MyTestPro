using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnity.Models;

namespace TestUnity.DAL
{
    public class GongChengDAL:BaseDAL<gongchengs>,IGongChengDAL
    {
         BaseContext userContext;
         public GongChengDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
