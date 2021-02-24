/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class to validate an user, this implements UserDataValidations class
 */

using BusinessObjects.User;
using ConsoleUI.ConsoleOutput;

namespace ConsoleUI.Validations
{
    /// <summary>
    /// Contains a function to validate a new user
    /// </summary>
    public static class ValidateUser
    {
        /// <summary>
        /// Validates if the user username and password are valid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Validate(IUser user)
        {
            bool usernameValidator = UserDataValidations.Username(user.Username);
            bool passwordValidator = UserDataValidations.Password(user.Password);

            if (usernameValidator == false)
            {
                StandardMessages.InvalidUsernameMessage(user.Username);
                return false;
            }
            if (passwordValidator == false)
            {
                StandardMessages.InvalidPasswordMessage(user.Password);
                return false;
            }

            return true;
        }
    }
}