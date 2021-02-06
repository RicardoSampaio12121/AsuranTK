/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2000
 * Resume: This file contains a class that has methods to Write an error message 
 *         to the console when the user types an invalid input, such as a string when an 
 *         integer is asked or when given three option, being those three options being 
 *         represented by 1, 2 and 3, the user inputs neither of those numbers
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class InvalidInputErrors
    {
        public static void InvalidInputFormatMessage()
        {
            Console.WriteLine("Invalid input format: input should be an integer!\n" +
                              "Press any key to continue...");
            Console.ReadKey();
        }

        public static void InputOutOfRange(int minimum, int maximum)
        {
            Console.WriteLine($"Invalid input: input must be between {minimum} and {maximum}!\n" +
                              "Press any key to continue...");
            Console.ReadKey();
        }
    }
}