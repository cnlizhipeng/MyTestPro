using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFWCF.Models
{
    [Table("SYS_Organization")]
    public class Organization : IModelBase
    {
        [Key]
        public int ID { get; set; }
        public int PID { get; set; }
        [MaxLength(50)]
        [Required]
        public string OrgName { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrgType { get; set; }
    }
}
