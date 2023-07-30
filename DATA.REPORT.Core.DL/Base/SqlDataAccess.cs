using DATA.REPORT.Library.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.REPORT.Core.DL
{
    public class SqlDataAccess : BaseDL
    {
        public SqlDataAccess(IConfigUtil configUtil) : base(configUtil)
        {
        }

        public SqlDataAccess(string connectionString) : base(connectionString)
        {
        }
    }
}
