using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.REPORT.Library
{
    public static class FunctionUtil
    {
        /// <summary>
        /// Get value by property name
        /// </summary>
        /// <param name="src"></param>
        /// <param name="propName"></param>
        /// <returns>Value</returns>
        public static object? GetValueByPropertyName(this object src, string propName)
        {
            if (src == null || !src.HasProperty(propName)) return null;

            return src.GetType()?.GetProperty(propName)?.GetValue(src, null);
        }

        /// <summary>
        /// Has property by property name
        /// </summary>
        /// <param name="src"></param>
        /// <param name="propName"></param>
        /// <returns>Value</returns>
        public static bool HasProperty(this object src, string propName)
        {
            return src?.GetType()?.GetProperty(propName) != null;
        }
    }
}
