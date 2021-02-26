using System;
using System.Collections.Generic;

namespace ConsoleUI.ConsoleOutput
{
    /// <summary>
    /// Writes to the console the formatted output of the command
    /// </summary>
    public static class CommandsOutput
    {
        /// <summary>
        /// Writes to the console the SearchItem command output
        /// </summary>
        /// <param name="output"></param>
        public static void WriteSearchItem(Dictionary<string, int> output)
        {
            //TODO: organizar isto numa tabela como no bot do discord
            foreach (var (key, value) in output)
            {
                Console.WriteLine($"{key}: {value}");    
            }
        }

        public static void WriteGoldToGemsExchange(int gems)
        {
            Console.WriteLine($"Gems: {gems}");
        }

        public static void WriteGemsToGoldExchange(int gold)
        {
            Console.WriteLine($"Gold: {gold}");
        }
    }
}