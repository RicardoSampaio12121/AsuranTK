/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2021
 */


using System;
using BusinessObjects.User;
using ConsoleUI.ConsoleOutput;

namespace ConsoleUI.DataCollectors
{
    /// <summary>
    /// Contains functions to gather all types of data from the user
    /// </summary>
    public static class UserData
    {
        /// <summary>
        /// Gather data to create a new user
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public static IUser GatherNewUserData(IUser output)
        {
            Console.Write("Username: ");
            output.Username = Console.ReadLine();
            
            
            Console.Write("Password: ");
            output.Password = Console.ReadLine();
            Console.Write("Api key: ");
            output.Apikey = Console.ReadLine();

            return output;
        }
        
        /// <summary>
        /// Gather login data
        /// </summary>
        /// <returns></returns>
        public static (string, string) GatherLoginData()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            
            Console.Write("Password: ");
            string password = Console.ReadLine();
            
            return (username, password);
        }

        /// <summary>
        /// Gather command to execute
        /// </summary>
        /// <returns></returns>
        public static string GatherCommand()
        {
            Console.Write("% ");
            return Console.ReadLine();
        }
        
        /// <summary>
        /// Gather the amount of gold the user wants to exchange
        /// </summary>
        /// <returns></returns>
        public static int GatherGold()
        {
            Console.WriteLine("Gold to convert: ");
            if(!int.TryParse(Console.ReadLine(), out var output))
            {
                InvalidInputErrors.InvalidInputFormatMessage("integer");
            }
            return output;
        }
    }
}