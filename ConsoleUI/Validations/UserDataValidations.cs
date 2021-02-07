/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class that validates user data(password, username...)
 */

using System.Text.RegularExpressions;

namespace ConsoleUI.Validations
{
    public static class UserDataValidations
    {
        public static bool Username(string username)
        {
            return Regex.IsMatch(username, "^[a-z0-9A-Z].*?$");
        }

        public static bool Password(string password)
        {
            return password.Length >= 8 && password.Length <= 20;
        }
    }
}