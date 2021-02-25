/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2021
 */

using System;

namespace ConsoleUI.ConsoleOutput
{
    /// <summary>
    /// Contains functions to create all the menus that can appear throughout the execution of the program
    /// </summary>
    public static class Menus
    {
        /// <summary>
        /// Prints to the console a menu with the login and registration options
        /// </summary>
        public static void LoginRegistrationMenu()
        {
            Console.WriteLine("(1) LOGIN");
            Console.WriteLine("(2) REGISTER");
            Console.Write("Decision: ");
        }
        
        /// <summary>
        /// Prints to the console all the command options
        /// </summary>
        public static void CommandsMenu()
        {
            Console.WriteLine("(1) Search item");
            Console.WriteLine("(2) Currency converter");
            Console.Write("Decision: ");
        }

        public static void CurrencyConverterMenu()
        {
            Console.Clear();
            Console.WriteLine("(1) Gold to gems");
            Console.WriteLine("(2) Gems to gold");
            Console.WriteLine("Decision: ");
        }
    }
}