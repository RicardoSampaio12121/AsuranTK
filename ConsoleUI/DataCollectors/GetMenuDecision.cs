/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 */

using System;
using ConsoleUI.ConsoleOutput;

namespace ConsoleUI.DataCollectors
{
    /// <summary>
    /// This class contains functions to get the option of the menu the user wants to enter
    /// </summary>
    public static class GetMenuDecision
    {
        /// <summary>
        /// Gets the decision of a menu expecting an integer
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        public static int ExpectIntegerMenu(int minimum, int maximum)
        {
            if (!int.TryParse(Console.ReadLine(), out var output))
            {
                InvalidInputErrors.InvalidInputFormatMessage("integer");
            }
            else if (output < minimum || output > maximum)
            {
                InvalidInputErrors.InputOutOfRange(1, 2);
            }

            return output;
        }
    }
}