using System;
using System.Linq.Expressions;
using BusinessObjects.User;
using ConsoleUI.Validations;
using DBManager;
using Exceptions;
using Logic.Application;
using MySql.Data.MySqlClient;
using ValidateUser = ConsoleUI.Validations.ValidateUser;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            bool logged = false;
            
            Menus.LoginRegistationMenu();
            int decision = GetMenuDecision.ExpectIntegerMenu(1, 2); 
            
            switch (decision)
            {
                case 1: //Login process
                    Console.Clear();
                    //Gather username and password
                    string username, password;
                    (username, password) = UserData.GatherLoginData();

                
                    try
                    {
                        var login = LoginController.Login(username, password);

                        if (login == true)
                        {
                            logged = true;
                        }
                        else
                        {
                            StandardMessages.FailedLogin();
                            StandardMessages.PressKeyContinueMessage();
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ERROR: {ex.Message}");
                    }

                    break;
                case 2: //Registration process
                {   
                    Console.Clear();
                    IUser newUser = BusinessObjects.Factory.CreateUser();
                    
                    //Gather data from the user
                    newUser = UserData.GatherNewUserData(newUser);
                
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
                        if (userValidator == false)
                        {
                            StandardMessages.UsernameInUse(newUser.Username);
                            StandardMessages.PressKeyContinueMessage();
                            Console.ReadKey();
                            break;
                        }
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

            if (logged == true)
            {
                string apiKey = "35D002B7-3426-A947-9C4D-16CDE1431D42D515E25E-AEEE-4227-A204-9BDEEE0B25E2";
                TestController.Test(apiKey);


            }
        }
    }
}