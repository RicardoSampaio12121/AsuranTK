using BusinessObjects.User;

namespace DBManager.UsersDatabase
{
    
    public class UsersDatabaseManagers : IUserDatabaseManager
    {
        public void Insert(IUser user)
        {
            //Creates a sql connection and an sql command
            using var sqlConnection = Factory.NewSqlConnection(ConnectionStrings.UsersConString);
            using var sqlCommand = Factory.NewSqlCommand(UsersSqlQueries.InsertUserQuery, sqlConnection);
            
            //Assigns the values to the 
            sqlCommand.Parameters.AddWithValue("@user", user.Username);
            sqlCommand.Parameters.AddWithValue("@pass", user.Password);
            sqlCommand.Parameters.AddWithValue("@api", user.Apikey);
            
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}