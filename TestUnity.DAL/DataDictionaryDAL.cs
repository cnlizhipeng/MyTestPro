using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.IDAL;
namespace EFWCF.DAL
{
    public class DataDictionaryDAL : BaseDAL<DataDictionary>, IDataDictionaryDAL
    {
        BaseContext userContext;
        public DataDictionaryDAL(BaseContext context)
            : base(context)
        {
            userContext = context;
        }
    }
}
