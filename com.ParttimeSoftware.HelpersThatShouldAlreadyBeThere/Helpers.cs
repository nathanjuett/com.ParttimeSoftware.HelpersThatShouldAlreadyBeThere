using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ParttimeSoftware.HelpersThatShouldAlreadyBeThere
{
    public static class Helpers
    {
        public static string ToString<T>(this T obj, char Delimiter)
            where T : class
        {
            if (typeof(T).GetInterface("IEnumerable`1") != null)
                return ((IEnumerable)obj).ToCSVString(Delimiter);

            StringBuilder sb = new StringBuilder();
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (typeof(T).GetInterface("Key") != null)
                    return ((IEnumerable)obj).ToCSVString(Delimiter);

                var value = Convert.ChangeType(prop.GetValue(obj), prop.PropertyType);
                if (value == null)
                    continue;
                if (prop.PropertyType == typeof(string))
                    sb.Append('"' + value.ToString().Replace("\"", "\"\"") + '"');
                else if (prop.PropertyType.IsClass)
                    sb.Append('"' + value.ToString(Delimiter) + '"');
                else
                    sb.Append(value).ToString();
                sb.Append(Delimiter);
            }
            return sb.ToString().Substring(0, sb.ToString().Length - 1);
        }
        private static string ToCSVString(this IEnumerable list, char Delimiter)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var row in list)
            {
                sb.AppendLine(row.ToString(Delimiter));
            }
            return sb.ToString();
        }
    }
}
