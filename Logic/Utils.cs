using System;

namespace Logic
{
    public class Utils
    {
        public static (string com, string parameter) ParseCommand(string command)
        {
            string com = "";
            foreach (var character in command)
            {
                if (character == ' ')
                {
                    break;
                }
                com += character;
            }
            int i = command.IndexOf(" ", StringComparison.Ordinal)+1;
            string param = command.Substring(i);
            
           
            return (com, param);
        }
    }
}