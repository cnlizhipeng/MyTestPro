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
    public class DataDictionaryBLL:BaseBLL<DataDictionary>
    {
        IDataDictionaryDAL dal;
        public DataDictionaryBLL()
        {
            dal = base.BaseContainer.Resolve<IDataDictionaryDAL>();
            base.BaseDAL = dal;
        }

        public DataDictionaryBLL(IDataDictionaryDAL _dal)
        {
            base.BaseDAL = _dal;
        }
    }
}
