/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 * Resume: This file contains everything that has to do with
 *         registering a new user.
 */

using BusinessObjects;
using Logic.Validations;

namespace Logic.Application
{
    public static class NewUserController
    {
        public static void NewUserRegistration(string username, string password, string apikey)
        {
            //check if the username and password are valid
            //These two methods will throw an exception caught
            //that must be caught in presentation
            NewUserValidations.Username(username);
            NewUserValidations.Password(password);

            //Create a new instance of the User class
            var newUser = new User(username, password, apikey);

            //Save user to database
            
        }
    }
}