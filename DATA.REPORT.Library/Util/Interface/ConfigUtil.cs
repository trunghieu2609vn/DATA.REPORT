using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.REPORT.Library.Util
{
    public class ConfigUtil : IConfigUtil
    {
        #region Declare

        private readonly AppSettings _appSettings;

        #endregion

        #region Constructor
        public ConfigUtil(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        /// <summary>
        /// Get setting
        /// </summary>
        /// <param name="key">Key appsetting</param>
        /// <returns></returns>
        public object? GetAppsetting(string key)
        {
            if (_appSettings != null && _appSettings.HasProperty(key))
            {
                return _appSettings.GetValueByPropertyName(key);
            }

            return null;
        }
        #endregion


    }
}
