using System;
using BusinessObjects.User;
using ConsoleUI.Validations;
using Exceptions;
using Logic.Application;
using MySql.Data.MySqlClient;
using ValidateUser = ConsoleUI.Validations.ValidateUser;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            Menus.LoginRegistationMenu();
            int decision = GetMenuDecision.ExpectIntegerMenu(1, 2); 
            
            switch (decision)
            {
                case 1: //Login process
                    
                    
                    break;
                case 2: //Registration process
                {   
                    Console.Clear();
                    IUser newUser = BusinessObjects.Factory.CreateUser();
                    
                    //Gather data from the user
                    newUser = UserData.Gather(newUser);
                
                    //Validates data given from the user
                    bool userValidator = ValidateUser.Validate(newUser);
                    
                    //If the data is not valid, registration process won't proceed
                    if (userValidator == false) 
                    {
                        StandardMessages.PressKeyContinueMessage();
                        Console.ReadKey();
                        break;
                    }
                    
                    //Tries to insert the user in the database
                    try
                    {
                        userValidator = NewUserController.Registration(newUser);
                    }
                    catch (Exception ex) //If it can't, registration process won't proceed
                    {
                        Console.WriteLine($"ERROR: {ex.Message} ");
                        StandardMessages.PressKeyContinueMessage();
                        Console.ReadKey();
                        break;
                    }
                    
                    //Writes a message saying the user was created
                    StandardMessages.UserCreatedSuccessfully();
                    StandardMessages.PressKeyContinueMessage();
                    Console.ReadKey();

                    break;
                }
            }
        }
    }
}