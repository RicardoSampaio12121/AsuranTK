using System;

namespace Logic
{
    public static class StandardMessages
    {
        public static void InvalidUsernameMessage(string username)
        {
            Console.WriteLine($"Invalid username {username}: username must contain only letters or numbers!");
        }

        public static void InvalidPasswordMessage(string password)
        {
            Console.WriteLine($"Invalid password {password}: password must be between 8 and 20 characters long!");
        }
    }
}