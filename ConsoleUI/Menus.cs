/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2021
 * Resume: This file contains a class to print to the console all the menus
 *         throughout the program running in the console UI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Menus
    {
        /// <summary>
        /// Prints to the console a menu with the login and registration options
        /// </summary>
        public static void LoginRegistationMenu()
        {
            Console.WriteLine("(1) LOGIN");
            Console.WriteLine("(2) REGISTER");
            Console.Write("Decision: ");
        }

        public static void CommandsMenu()
        {
            Console.WriteLine("(1) Search item");
            Console.Write("Decision: ");
        }
    }
}