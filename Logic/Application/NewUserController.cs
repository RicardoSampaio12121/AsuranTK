/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 * Resume: This file contains everything that has to do with
 *         registering a new user.
 */

using BusinessObjects.User;
using Logic.Validations;

namespace Logic.Application
{
    public static class NewUserController
    {
        public static bool Registration(IUser user)
        {
            //Validate data from user
            //If the data is not valid it will throw an exception
            bool validator = ValidateUser.Validate(user);

            if (validator == false) return false;
            
            //Save user to database    
            var userDb = DBManager.Factory.InitializeUserDb();
            userDb.Insert(user);
            return true;
        }
    }
}