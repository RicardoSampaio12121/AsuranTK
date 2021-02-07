/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class to validate an user, this implements UserDataValidations class
 */

using BusinessObjects.User;

namespace ConsoleUI.Validations
{
    public static class ValidateUser
    {
        public static bool Validate(IUser user)
        {
            bool usernameValidator = UserDataValidations.Username(user.Username);
            bool passwordValidator = UserDataValidations.Password(user.Password);

            if (usernameValidator == false)
            {
                StandardMessages.InvalidUsernameMessage(user.Username);
                return false;
            }
            else if (passwordValidator == false)
            {
                StandardMessages.InvalidPasswordMessage(user.Password);
                return false;
            }

            return true;
        }
    }
}