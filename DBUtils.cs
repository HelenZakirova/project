using System;
using MySql.Data.MySqlClient;

namespace Project
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "delivery";
            string user = "root";
            string password = "2375425";
            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}

