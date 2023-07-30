using DATA.REPORT.Library;
using DATA.REPORT.Library.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.REPORT.Core.DL
{
    public class BaseDL
    {
        #region Declare

        /// <summary>
        /// Connection String
        /// </summary>
        private string ConnectionString { get; set; }

        #endregion

        #region Constructor

        public BaseDL(IConfigUtil configUtil)
        {
            var appConnection = configUtil.GetAppsetting(nameof(AppSettings.Connection));
            if (appConnection != null)
            {
                ConnectionString = appConnection.ToString() ?? string.Empty;
            }
        }

        public BaseDL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        #endregion

        #region Method

        #region Private

        //private IDbConnection CreateConnection()
        //{
            
        //}
        #endregion

        #endregion

    }
}
