using System;
using BusinessObjects.User;

namespace ConsoleUI
{
    public static class UserData
    {
        public static IUser Gather(IUser output)
        {
            Console.Write("Username: ");
            output.Username = Console.ReadLine();
            
            
            Console.Write("Password: ");
            output.Password = Console.ReadLine();
            Console.Write("Api key: ");
            output.Apikey = Console.ReadLine();

            return output;
        }
    }
}