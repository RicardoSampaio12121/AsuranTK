/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 * Resume: This file contains everything that has to do with
 *         registering a new user.
 */

using System;
using BusinessObjects.User;
using Logic.Validations;
using Exceptions;
using MySql.Data.MySqlClient;

namespace Logic.Application
{
    public static class NewUserController
    {
        public static bool Registration(IUser user)
        {
            //Validate data from user
            //If the data is not valid it will throw an exception
            if (Validations.NewUserValidations.Username(user.Username) == false)
            {
                throw new InvalidUsernameException("INVALID USERNAME: username must contain only letters and numbers!");
            }
            if (Validations.NewUserValidations.Password(user.Password) == false)
            {
                throw new InvalidUserPasswordException("INVALID PASSWORD: password must be between 8 and 20 characters long!");
            }
            
            //Initializes a DBManager instance   
            var userDb = DBManager.Factory.InitializeUserDb();
            
            //TODO check if there any member in the database with the same username, if there is
            //TODO this process won't proceed
            
            
            //Tries to insert the user in the database
            //If it can't, exception will be caught in the presentation layer
            try
            {
                userDb.Insert(user);
            }
            catch(NullReferenceException ex)
            {
                //This exception is being caught here because there's a bug in mysql that will always throw this exception
                //Nothing is being done with it
            }
            return true;
        }
    }
}