using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.REPORT.Library.Util
{
    public interface IConfigUtil
    {
        /// <summary>
        /// Get setting
        /// </summary>
        /// <param name="key">Key appsetting</param>
        /// <returns></returns>
        object? GetAppsetting(string key);
    }
}
