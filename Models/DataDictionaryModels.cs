using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWCF.Models
{
    [Table("SYS_DataDictionary")]
    public class DataDictionary : IModelBase
    {
        public int ID { get; set; }
        public int PID { get; set; }
        [Required]
        [MaxLength(100)]
        public string DictionaryName { get; set; }
        public int ViewOrder { get; set; }
        [MaxLength(100)]
        public string PYM { get; set; }
        [MaxLength(50)]
        public string PYJM { get; set; }
        [MaxLength(400)]
        public string CodeValue { get; set; }
    }
}
