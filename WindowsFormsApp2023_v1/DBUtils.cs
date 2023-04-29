using MySql.Data.MySqlClient;

namespace WindowsFormsApp2023_v1
{
    internal class DBUtils
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "db_variant_9";
            string user = "monty";
            string password = "some_pass";

            return DBMySqlUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
