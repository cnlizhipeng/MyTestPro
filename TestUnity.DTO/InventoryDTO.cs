using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.DTO
{
    public class MaterialBaseInfoDTO : BaseDTO
    {
        public int ID { get; set; }
        public string MaterialName { get; set; }
        public string MaterialNo { get; set; }
        public string MaterialUnit { get; set; }
        public string MaterialModel { get; set; }
        public decimal MaterialPrice { get; set; }
    }
}
