using System;
using System.Data;

namespace ConsoleUI
{
    public static class StandardMessages
    {
        public static void InvalidUsernameMessage(string username)
        {
            Console.WriteLine($"Invalid username {username}: username must contain only letters and numbers!");
        }

        public static void InvalidPasswordMessage(string password)
        {
            Console.WriteLine($"Invalid password {password}: password must be between 8 and 20 characters long!");
        }

        public static void PressKeyContinueMessage()
        {
            Console.WriteLine("Press any key to continue...");
        }

        public static void UserCreatedSuccessfully()
        {
            Console.WriteLine("New user successfully created!");
        }

        public static void UsernameInUse(string username)
        {
            Console.WriteLine($"Username {username} is already in use.");
        }
    }
}