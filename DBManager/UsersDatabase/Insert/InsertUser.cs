﻿using System;
using System.Data;
using BusinessObjects.User;
using Exceptions;

namespace DBManager.UsersDatabase.Insert
{
    public class InsertUser : IInsertUser
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
            
            //Tries to open the database connection
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new OpenDatabaseException();
            }
            
            //Tries to execute the command
            try
            {
                sqlCommand.Prepare();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new ExecuteNonQueryException("could not insert user into database.", ex);
            }
            finally //Closes the connection no matter what
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}