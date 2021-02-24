/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class that validates user data(password, username...)
 */

using System.Text.RegularExpressions;

namespace ConsoleUI.Validations
{
    
    /// <summary>
    /// Contains functions to validate the username and password of a new user
    /// </summary>
    public static class UserDataValidations
    {
        /// <summary>
        /// Validates a new user username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool Username(string username)
        {
            return Regex.IsMatch(username, "^[a-z0-9A-Z].*?$");
        }
        
        /// <summary>
        /// Validates a new user password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Password(string password)
        {
            return password.Length >= 8 && password.Length <= 20;
        }
    }
}