using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWCF.Common
{
    public class PagerInfo
    {
        /// <summary>
        /// 页总数
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageDataCount { get; set; }
        /// <summary>
        /// 数据总条数
        /// </summary>
        public int DataCount { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage { get; set; }
    }
}
