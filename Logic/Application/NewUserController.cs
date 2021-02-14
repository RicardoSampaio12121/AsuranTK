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
using DBManager;

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
            var usersDbInsert = DBManager.Factory.InitializeUsersDbInsert();
            var usersDbInspect = DBManager.Factory.InitializeUsersDbInspection();
    
            //Check if there is any user with the same username
            //if there is, return false to UI
            bool exists = usersDbInspect.CheckIfUserInDatabaseByUsername(user.Username);

            if (exists == true)
            {
                return false;
            }
            
            //Tries to insert the user in the database
            //If it can't, exception will be caught in the presentation layer
            usersDbInsert.Insert(user);
           
           
            return true;
        }
    }
}