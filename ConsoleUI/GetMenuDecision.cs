/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: This file contains a class to 
 */

using System;
using BusinessObjects.User;

namespace ConsoleUI
{
    public static class GetMenuDecision
    {
        public static int ExpectIntegerMenu(int minimum, int maximum)
        {
            if (!int.TryParse(Console.ReadLine(), out var output))
            {
                InvalidInputErrors.InvalidInputFormatMessage();
            }
            else if (output < minimum || output > maximum)
            {
                InvalidInputErrors.InputOutOfRange(1, 2);
            }

            return output;
        }
    }
}