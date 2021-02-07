/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 07/02/2021
 * Resume: Is only here to not repeat it in the Main
 */

using System;

namespace ConsoleUI.Validations
{
    public static class ValidateIsFalseHandler
    {
        public static bool Validate(bool validator)
        {
            if (validator == true)
            {
                return true;
            }
            StandardMessages.PressKeyContinueMessage();
            Console.ReadKey();
            return false;

        }
    }
}