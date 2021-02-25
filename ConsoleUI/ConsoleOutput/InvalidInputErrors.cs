/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2000
 */

using System;

namespace ConsoleUI.ConsoleOutput
{
    /// <summary>
    /// Contains functions to inform the user of invalid inputs
    /// </summary>
    public static class InvalidInputErrors
    {
        /// <summary>
        /// Writes a message informing the user that the input must be an integer
        /// </summary>
        public static void InvalidInputFormatMessage(string expected)
        {
            Console.WriteLine($"Invalid input format: input should be an {expected}!\n" +
                              "Press any key to continue...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Writes a message informing the user that the input is out of range, must be between minimum and maximum
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public static void InputOutOfRange(int minimum, int maximum)
        {
            Console.WriteLine($"Invalid input: input must be between {minimum} and {maximum}!\n" +
                              "Press any key to continue...");
            Console.ReadKey();
        }
    }
}