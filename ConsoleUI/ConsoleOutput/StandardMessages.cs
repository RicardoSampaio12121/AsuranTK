/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2021
 */

using System;

namespace ConsoleUI.ConsoleOutput
{
    /// <summary>
    /// Contains functions with standard messages that can be user throughout the program
    /// </summary>
    public static class StandardMessages
    {
        /// <summary>
        /// Writes a message informing the user that the input username is invalid
        /// </summary>
        /// <param name="username"></param>
        public static void InvalidUsernameMessage(string username)
        {
            Console.WriteLine($"Invalid username {username}: username must contain only letters and numbers!");
        }
        
        /// <summary>
        /// Writes a message informing the user that the input password is invalid
        /// </summary>
        /// <param name="password"></param>
        public static void InvalidPasswordMessage(string password)
        {
            Console.WriteLine($"Invalid password {password}: password must be between 8 and 20 characters long!");
        }
        
        /// <summary>
        /// Writes a message informing the user to press any key to continue the execution of the program
        /// </summary>
        public static void PressKeyContinueMessage()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Writes a message informing the user that the registration was done successfully
        /// </summary>
        public static void UserCreatedSuccessfully()
        {
            Console.WriteLine("Successful registration!");
        }
        
        /// <summary>
        /// Writes a message informing the user that the input username, used to register, is already in use
        /// </summary>
        /// <param name="username"></param>
        public static void UsernameInUse(string username)
        {
            Console.WriteLine($"Username {username} is already in use.");
        }
        
        /// <summary>
        /// Writes a message to inform the user that the login was unsuccessful
        /// </summary>
        public static void FailedLogin()
        {
            Console.WriteLine("Unsuccessful login");
        }
    }
}