using System;
using BusinessObjects.User;

namespace ConsoleUI
{
    public static class UserData
    {
        public static IUser GatherNewUserData(IUser output)
        {
            Console.Write("Username: ");
            output.Username = Console.ReadLine();
            
            
            Console.Write("Password: ");
            output.Password = Console.ReadLine();
            Console.Write("Api key: ");
            output.Apikey = Console.ReadLine();

            return output;
        }

        public static (string, string) GatherLoginData()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            
            Console.Write("Password: ");
            string password = Console.ReadLine();
            
            return (username, password);
        }
    }
}