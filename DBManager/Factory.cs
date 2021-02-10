using DBManager.UsersDatabase;
using MySql.Data.MySqlClient;

namespace DBManager
{
    public static class Factory
    {
        public static MySqlConnection NewSqlConnection(string conString)
        {
            return new MySqlConnection(conString);
        }
        
        public static MySqlCommand NewSqlCommand(string query, MySqlConnection con)
        {
            return new MySqlCommand(query, con);
        }

        public static InsertUser InitializeInsertUser()
        {
            return new InsertUser();
        }
    }
}