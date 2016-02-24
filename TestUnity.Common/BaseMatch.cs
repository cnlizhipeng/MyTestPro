using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EFWCF.Common
{
    public abstract class BaseMatch<T> where T:class
    {
        public abstract Expression<Func<T, bool>> GetExpressionFromString(string match, object[] options, string fieldName);
    }
}
