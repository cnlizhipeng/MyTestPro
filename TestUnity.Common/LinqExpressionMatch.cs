using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace EFWCF.Common
{
    public class LinqExpressionMatch<T> where T : class
    {
        public static System.Linq.Expressions.Expression<Func<T, bool>> GetExpressionFromString(string match, object[] options, string fieldName)
        {

            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>
            Expression expression = Expression.Constant(false);
            foreach (var optionName in options)
            {
                Expression right = Expression.Call
                       (
                          Expression.Property(left, typeof(T).GetProperty(fieldName)), //c.DataSourceName
                          typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),//反射使用.Contains()方法                         
                          Expression.Constant(optionName)           // .Contains(optionName)
                       );
                expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }

        public static System.Linq.Expressions.Expression<Func<T, bool>> GetExpressionFromString(IEnumerable<PropertyMatch> listProperty)
        {

            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>
            Expression expression = Expression.Constant(true);

            if (listProperty != null && listProperty.Where(e => e == null).Count() == 0)
            {
                var orderlist = listProperty.ToList();
                int intCount = orderlist.Count();
                for (int index = 0; index < intCount; index++)
                {
                    var optionName = orderlist[index];
                    //Expression right = Expression.Call
                    //       (
                    //          Expression.Property(left, typeof(T).GetProperty(optionName.PropertyName)), //c.DataSourceName
                    //          typeof(string).GetMethod("Equals", new Type[] { typeof(int) }),//反射使用.Contains()方法                         
                    //          Expression.Constant(optionName)           // .Contains(optionName)
                    //       );
                    for (int q = 0; q < optionName.Value.Count; q++ )
                    {
                        if (q == 2)
                            break;
                        string valQ = optionName.Value[q];
                        if (optionName.PropertyType.Equals(typeof(string).FullName) || optionName.PropertyType.Equals(typeof(Guid).FullName))
                        { //字符串
                            Expression right = Expression.Call
                                   (
                                      Expression.Property(left, typeof(T).GetProperty(optionName.PropertyName)), //c.DataSourceName
                                      typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),//反射使用.Contains()方法                         
                                      Expression.Constant(valQ)           // .Contains(optionName)
                                   );
                            expression = Expression.AndAlso(right, expression);
                            break;
                        }
                        else
                        {//日期时间---数字
                            Expression right = Expression.Constant(false);
                            if (optionName.Value.Count == 2 && q == 0)
                            {
                                right = Expression.GreaterThanOrEqual
                                       (
                                       Expression.Property(left, optionName.PropertyName),
                                       Expression.Constant(GetVal(valQ, optionName.PropertyType))
                                       );
                            }
                            else if (optionName.Value.Count == 2)
                            {
                                right = Expression.LessThanOrEqual
                                      (
                                      Expression.Property(left, optionName.PropertyName),
                                      Expression.Constant(GetVal(valQ, optionName.PropertyType))
                                      );
                            }
                            else
                            {
                                right = Expression.Equal
                                       (
                                       Expression.Property(left, optionName.PropertyName),
                                       Expression.Constant(GetVal(valQ, optionName.PropertyType))
                                       );
                            }
                            expression = Expression.AndAlso(right, expression);
                        }
                    }

                    //var parameter = Expression.Parameter(typeof(Person), "p");
                    //var left = Expression.Call(
                    //    Expression.Property(parameter, "Name"),
                    //    typeof(string).GetMethod("Contains"),
                    //    Expression.Constant("ldp"));
                    //var right = Expression.GreaterThan(
                    //    Expression.Property(Expression.Property(Expression.Property(parameter, "Birthday"), "Value"), "Year"),
                    //    Expression.Constant(1990));
                    //var body = Expression.AndAlso(left, right);
                    //var lambda = Expression.Lambda<Func<Person, bool>>(body, parameter);


                    //var parameter = Expression.Parameter(typeof(T), "p");
                    //var left = parameter.Property("Name").Call("Contains", Expression.Constant("ldp"));
                    //var right = parameter.Property("Birthday").Property("Value").Property("Year").GreaterThan(Expression.Constant(1990));
                    //var lambda = left.AndAlso(right).ToLambda<Func<Person, bool>>(parameter);
                }
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }

        public static Expression<Func<T, TKey>> GetOrderExpressionFromString<TKey>(PropertyOrder listProperty)
        {

            //ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>
            //Expression expression = Expression.Constant(false);
            //foreach (var optionName in options)
            //{
            //    Expression right = Expression.Call
            //           (
            //              Expression.Property(left, typeof(T).GetProperty(fieldName)), //c.DataSourceName
            //              typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),//反射使用.Contains()方法                         
            //              Expression.Constant(optionName)           // .Contains(optionName)
            //           );
            //    expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            //}
            //Expression<Func<T, TKey>> finalExpression
            //    = Expression.Lambda<Func<T, TKey>>(expression, new ParameterExpression[] { left });
            //return finalExpression;
            return null;
        }

        private static object GetVal(object val, string valType)
        {

            Type t = Type.GetType(valType);
            MethodInfo mi = t.GetMethod("Parse", new Type[] { typeof(string) });
            if (mi != null)
            {
                return mi.Invoke(valType, new object[] { val });
            }
            else
            {
                return null;
            }
        }
        //public PageData<T> FindAll(int PageIndex, int PageSize, Expression<Func<T, bool>> condition, String orderByExpression, bool IsDESC)
        //{
        //    var property = typeof(T).GetProperty(orderByExpression);
        //    var parameter = Expression.Parameter(typeof(T), "p");
        //    var propertyAccess = Expression.MakeMemberAccess(parameter, property);
        //    var orderByExp = Expression.Lambda(propertyAccess, parameter);
        //    string methodName = IsDESC ? "OrderByDescending" : "OrderBy";
        //    MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { typeof(T), property.PropertyType }, query.Expression, Expression.Quote(orderByExp));
        //    query = query.Provider.CreateQuery<T>(resultExp);
        //    PageData<T> pageData = new PageData<T>();
        //    pageData.TotalCount = query.Count();
        //    pageData.DataList = query.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        //    ObjectQuery<T> ss = query as ObjectQuery<T>;
        //    String sss = ss.ToTraceString();
        //    return pageData;
        //}
    }
}
