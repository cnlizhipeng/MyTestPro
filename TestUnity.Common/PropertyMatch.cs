using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EFWCF.Common
{
    [DataContract]
    public class PropertyMatch
    {
        public PropertyMatch(string pname, List<string> value, string propertyType)
        {
            PropertyName = pname;
            Value = value;
            PropertyType = propertyType;
        }
        [DataMember]
        public string PropertyName { get; private set; }
        [DataMember]
        public string PropertyType { get; private set; }
        [DataMember]
        public List<string> Value { get; private set; }
    }
}
