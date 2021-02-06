using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Application;
using Exceptions;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Menus.LoginRegistationMenu();
            if (!int.TryParse(Console.ReadLine(), out int decision))
                InvalidInputErrors.InvalidInputFormatMessage();
            else if (decision < 1 || decision > 2)
                InvalidInputErrors.InputOutOfRange(1, 2);


            switch (decision)
            {
                case 1:
                    break;
                case 2:
                {
                    Console.Clear();
                    Console.Write("Username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.Write("Api key: ");
                    string apiKey = Console.ReadLine();

                    try
                    {
                        NewUserController.NewUserRegistration(userName, password, apiKey);
                    }
                    catch(InvalidUsernameException uexc)
                    {
                        Console.WriteLine(uexc.Message);
                    }
                    catch(InvalidUserPasswordException pexc)
                    {
                        Console.WriteLine(pexc.Message);
                    }

                    break;
                }
            }
        }
    }
}