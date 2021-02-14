using System;
using System.Data;
using Exceptions;

namespace DBManager.UsersDatabase.Inspection
{
    public class Inspection : IInspection
    {
        public bool CheckIfUserInDatabaseByUsername(string username)
        {
            using var sqlConnection = Factory.NewSqlConnection(ConnectionStrings.UsersConString);
            using var sqlCommand =
                Factory.NewSqlCommand(UsersSqlQueries.CheckIfUsernameIsInDatabaseQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@user", username);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                throw new OpenDatabaseException();
            }
            
            try
            {
                sqlCommand.Prepare();
                var result = sqlCommand.ExecuteScalar();
                if (result.ToString() != "0")
                {
                    return true;
                }
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlCommand.Dispose();
                sqlConnection.Dispose();
            }

            return false;
        }

        public bool CheckIfUsernamePasswordMatch(string username, string password)
        {
            using var sqlConnection = Factory.NewSqlConnection(ConnectionStrings.UsersConString);
            using var sqlCommand = Factory.NewSqlCommand(UsersSqlQueries.ConfirmPasswordFromUsername, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@user", username);
            sqlCommand.Parameters.AddWithValue("@pass", password);


            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                throw new OpenDatabaseException();
            }

            try
            {
                sqlCommand.Prepare();
                var result = sqlCommand.ExecuteScalar();
                if (result.ToString() == "0")
                {
                    return false;
                }
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }    
            }

            return true;
        }

    }
}