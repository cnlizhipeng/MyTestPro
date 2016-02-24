using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFWCF.Models
{
    [Table("TU_ZhaoTouBxx")]
    public class ZhaoTouBxx : IModelBase
    {
        public int ID { get; set; }
        public int OrganizationID { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
        [MaxLength(200)]
        public string xmmc { get; set; }
        [MaxLength(100)]
        public string zbbh { get; set; }
        [MaxLength(100)]
        public string zbwh { get; set; }
        [MaxLength(100)]
        public string jfmc { get; set; }
        [MaxLength(100)]
        public string zbdljg { get; set; }
        [MaxLength(100)]
        public string zbbm { get; set; }
        public Nullable<System.DateTime> ddrq { get; set; }
        public Nullable<System.DateTime> jzrq { get; set; }
        public Nullable<System.DateTime> tbrq { get; set; }
        public Nullable<System.DateTime> gdrq { get; set; }
        [MaxLength(100)]
        public string ywlb { get; set; }
        [MaxLength(100)]
        public string tbzt { get; set; }
        [MaxLength(100)]
        public string zbts { get; set; }
        [MaxLength(100)]
        public string fbts { get; set; }
        [MaxLength(100)]
        public string dzbts { get; set; }
        [MaxLength(100)]
        public string qtts { get; set; }
        public Nullable<System.DateTime> cjrq { get; set; }
        [MaxLength(100)]
        public string spdzt { get; set; }
        public Nullable<bool> sfhczbtzs { get; set; }
        public Nullable<decimal> zbje { get; set; }
        [MaxLength(100)]
        public string lxr { get; set; }
        [MaxLength(100)]
        public string lxfs { get; set; }
        public Nullable<bool> sfgd { get; set; }
        [MaxLength(100)]
        public string bz { get; set; }
        public Nullable<bool> sftjgd { get; set; }
        public Nullable<bool> sfqy { get; set; }
        [MaxLength(100)]
        public string tbfzr { get; set; }
        public Nullable<System.DateTime> zzrq { get; set; }
        [MaxLength(100)]
        public string spr { get; set; }
        [MaxLength(100)]
        public string spbm { get; set; }
        public Nullable<System.DateTime> spsj { get; set; }
        [MaxLength(100)]
        public string spzt { get; set; }
        [MaxLength(100)]
        public string spyj { get; set; }
        [MaxLength(100)]
        public string sprlist { get; set; }
        [MaxLength(100)]
        public string dqsprname { get; set; }
        [MaxLength(100)]
        public string sseq_no { get; set; }
        public Nullable<bool> sftj { get; set; }
        [MaxLength(100)]
        public string pseq_no { get; set; }
        [MaxLength(100)]
        public string scfl { get; set; }
        [MaxLength(100)]
        public string jfbh { get; set; }
        [MaxLength(2000)]
        public string yi { get; set; }
        [MaxLength(2000)]
        public string er { get; set; }
        [MaxLength(2000)]
        public string san { get; set; }
        [MaxLength(100)]
        public string tbfzrseq_no { get; set; }
        [MaxLength(100)]
        public string gdryseq_no { get; set; }
        [MaxLength(100)]
        public string gdrxm { get; set; }
        public Nullable<bool> issgs { get; set; }
        public Nullable<decimal> zbzje { get; set; }
        public Nullable<decimal> tbbzj { get; set; }
        public Nullable<decimal> bsje { get; set; }
        public Nullable<bool> sftbss { get; set; }
        public Nullable<System.DateTime> sssj { get; set; }
        public Nullable<System.DateTime> scrq { get; set; }
        public Nullable<decimal> cssj { get; set; }
        [MaxLength(100)]
        public string dhqry_name { get; set; }
        [MaxLength(100)]
        public string dhqry_seq_no { get; set; }
        [MaxLength(100)]
        public string yhqry_name { get; set; }
        [MaxLength(100)]
        public string yhqry_seq_no { get; set; }
        public Nullable<bool> sfhq { get; set; }
        public Nullable<System.DateTime> hqgqsj { get; set; }
        public Nullable<bool> gcglbhq { get; set; }
        public Nullable<bool> scjybhq { get; set; }
        public Nullable<bool> bsthq { get; set; }
        public Nullable<bool> rlzybhq { get; set; }
        public Nullable<bool> wlzxhq { get; set; }
        public Nullable<bool> sjbhq { get; set; }
        public Nullable<bool> sfsctbxx { get; set; }
        [MaxLength(100)]
        public string bzjskdw { get; set; }
        [MaxLength(100)]
        public string khhmc { get; set; }
        [MaxLength(100)]
        public string khhzh { get; set; }
        [MaxLength(100)]
        public string fkfs { get; set; }
        [MaxLength(100)]
        public string tssm { get; set; }
        [MaxLength(100)]
        public string kj_name { get; set; }
        [MaxLength(100)]
        public string kj_SEQ_no { get; set; }
        [MaxLength(100)]
        public string ksbh { get; set; }
        [MaxLength(100)]
        public string pzzy { get; set; }
        public Nullable<bool> sfgz { get; set; }
        [MaxLength(100)]
        public string pzh { get; set; }
        public Nullable<int> fdjs { get; set; }
        public Nullable<bool> is_zf { get; set; }
        [MaxLength(100)]
        public string pk_voucher { get; set; }
        public Nullable<bool> sjcc { get; set; }
        public Nullable<System.DateTime> zdrq { get; set; }
        public Nullable<bool> zfzb { get; set; }
        [MaxLength(100)]
        public string skdw { get; set; }
        [MaxLength(100)]
        public string import1 { get; set; }
        [MaxLength(100)]
        public string import2 { get; set; }
        [MaxLength(100)]
        public string gzyhzh { get; set; }
        [MaxLength(100)]
        public string import3 { get; set; }
        [MaxLength(100)]
        public string jfmcfl { get; set; }
        [MaxLength(100)]
        public string import4 { get; set; }
        [MaxLength(100)]
        public string spbmlist { get; set; }
        public Nullable<decimal> zbfwf { get; set; }
        public Nullable<decimal> thbzj { get; set; }
        [MaxLength(100)]
        public string htpzh { get; set; }
        [MaxLength(100)]
        public string sgqy { get; set; }
        public Nullable<System.DateTime> TiJiaoGdrq { get; set; }
        public Nullable<bool> ShiFouKh { get; set; }
        [MaxLength(100)]
        public string KaoHeYy { get; set; }
        public Nullable<decimal> KaoHeFs { get; set; }
        public Nullable<decimal> FaKuanJe { get; set; }
        public Nullable<int> fushencs { get; set; }
    }
    [Table("TU_BiaoDuanXx")]
    public class BiaoDuanXx : IModelBase
    {
        public int ID { get; set; }
        public int ZhaoTouBxxID { get; set; }
        [Required]
        [MaxLength(100)]
        public string bdmc { get; set; }
        public Nullable<decimal> bdje { get; set; }
        [MaxLength(100)]
        public string bdgcmc { get; set; }
        public Nullable<bool> zb { get; set; }
        [MaxLength(100)]
        public string zbmc { get; set; }
        [MaxLength(100)]
        public string zbbh { get; set; }
        [MaxLength(100)]
        public string zbwh { get; set; }
        [MaxLength(100)]
        public string jfmc { get; set; }
        [MaxLength(100)]
        public string zbdljg { get; set; }
        [MaxLength(100)]
        public string tbbm { get; set; }
        public Nullable<System.DateTime> tbrq { get; set; }
        [MaxLength(100)]
        public string tbfzr { get; set; }
        [MaxLength(100)]
        public string tbfzrseq_no { get; set; }
        public Nullable<bool> wzb { get; set; }
        [MaxLength(100)]
        public string wzbsm { get; set; }
        public Nullable<decimal> zbfwf { get; set; }
        public Nullable<decimal> ygzbje { get; set; }
        public Nullable<int> zt { get; set; }
        [ForeignKey("ZhaoTouBxxID")]
        public virtual ZhaoTouBxx ZhaoTouBxx { get; set; }
    }
}
