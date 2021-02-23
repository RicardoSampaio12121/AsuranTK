using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class CommandsOutput
    {
        public static void WriteSearchItem(Dictionary<string, int> output)
        {
            foreach (var (key, value) in output)
            {
                Console.WriteLine($"{key}: {value}");    
            }
            
        }
    }
}