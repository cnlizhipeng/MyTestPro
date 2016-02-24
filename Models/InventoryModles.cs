using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWCF.Models
{
    [Table("INV_MaterialBaseInfo")]
    public class MaterialBaseInfo : IModelBase
    {
        public int ID { get; set; }
        [MaxLength(200)]
        public string MaterialName { get; set; }
        [MaxLength(200)]
        public string MaterialNo { get; set; }
        [MaxLength(200)]
        public string MaterialUnit { get; set; }
        [MaxLength(200)]
        public string MaterialModel { get; set; }
        public decimal MaterialPrice { get; set; }
    }
}
