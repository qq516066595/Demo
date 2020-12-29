using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels
{
    //Notify基类扩展,兼容lambda表达式
    public static class BaseTemplateExtend
    {
        public static void NotifyPropertyChanged<T, TProperty>(this T bt, Expression<Func<T, TProperty>> expression) where T : Demo.ViewModel
        {
            var propertyName = string.Empty;
            if ((expression.Body as UnaryExpression) != null)
            {
                propertyName = ((expression.Body as UnaryExpression).Operand as MemberExpression).Member.Name;
            }
            else if ((expression.Body as MemberExpression) != null)
            {
                propertyName = ((expression.Body as MemberExpression).Member.Name);
            }
            if (!string.IsNullOrEmpty(propertyName))
            {
                bt.Notify(propertyName);
            }
        }
    }
}
