using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EFWCF.Common
{
    [DataContract]
    public class PropertyOrder
    {
        [DataMember]
        public string PropertyName { get; private set; }
        [DataMember]
        public bool IsDesc { get; private set; }
        public PropertyOrder(string pname, bool isdesc = true)
        {
            PropertyName = pname;
            IsDesc = isdesc;
        }
    }
}
