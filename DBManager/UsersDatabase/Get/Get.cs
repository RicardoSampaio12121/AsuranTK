using System;
using System.Data;
using System.Xml;
using Exceptions;
using MySql.Data.MySqlClient;

namespace DBManager.UsersDatabase.Get
{
    public class Get : IGet
    {
        public string UserApiKey(string username)
        {
            using var sqlConnection = Factory.NewSqlConnection(ConnectionStrings.UsersConString);
            using var sqlCommand = Factory.NewSqlCommand(UsersSqlQueries.GetUserApiKeyQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@user", username);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new OpenDatabaseException();
            }


            try
            {
                using var reader = sqlCommand.ExecuteReader();
                reader.Read();
                return reader["apiKey"].ToString();
            }
            catch(Exception ex)
            {
                throw new ExecuteNonQueryException("could not get api key from database.", ex);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}