using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.DTO
{
    public class DataDictionaryDTO : BaseDTO
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public string DictionaryName { get; set; }
        public int ViewOrder { get; set; }
        public string PYM { get; set; }
        public string PYJM { get; set; }
        public string CodeValue { get; set; }
    }
}
