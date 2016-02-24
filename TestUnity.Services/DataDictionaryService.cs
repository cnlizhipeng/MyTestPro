using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.DTO;
using EFWCF.IServices;
using EFWCF.BLL;
namespace EFWCF.Services
{
    public class DataDictionaryService : ServiceBase<DataDictionaryDTO, DataDictionary>, IDataDictionaryService
    {
        public DataDictionaryService()
        {
            base.BaseBLL = new DataDictionaryBLL();
        }
    }
}
