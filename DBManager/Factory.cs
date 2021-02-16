using DBManager.UsersDatabase;
using DBManager.UsersDatabase.Get;
using DBManager.UsersDatabase.Insert;
using DBManager.UsersDatabase.Inspection;
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

        public static IInsertUser InitializeUsersDbInsert()
        {
            return new InsertUser();
        }

        public static IInspection InitializeUsersDbInspection()
        {
            return new Inspection();
        }

        public static IGet InitializeUserDbGet()
        {
            return new Get();
        }
    }
}