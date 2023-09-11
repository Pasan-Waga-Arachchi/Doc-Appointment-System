using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RAD_Project.BasicClasses
{
    class DBconnection
    {
        private SqlConnection sqlConnection=null;
        private static DBconnection dBconnection = null;
        private static string connectionString = null;
        private DBconnection() {
            dBconnection.sqlConnection = new SqlConnection(connectionString);
        }

        public static DBconnection getDBConnection() {
            if (dBconnection == null) {
                if (connectionString == null) { throw new Exception("ConnectionString is null"); }
                dBconnection = new DBconnection(); 
            }
            return dBconnection;
        }
        public SqlConnection SqlConnection { get { return sqlConnection; } }
        public string ConnectionString { set { connectionString = value; } }


    }
}
