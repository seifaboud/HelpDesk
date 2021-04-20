using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public static class Connection
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["helpdeskconn"].ConnectionString;
            return conn;
        }
    }
}
