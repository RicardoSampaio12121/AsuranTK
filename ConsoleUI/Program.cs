/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 28/01/2021
 */

using System;
using ConsoleUI.ConsoleOutput;
using ConsoleUI.DataCollectors;
using Logic.Application;
using Logic.Application.Commands;
using ValidateUser = ConsoleUI.Validations.ValidateUser;
using Factory = BusinessObjects.Factory;


namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            var logged = false;
            var loggedUser = Factory.CreateUser();
            
            Menus.LoginRegistrationMenu();
            var decision = GetMenuDecision.ExpectIntegerMenu(1, 2); 
            
            switch (decision)
            {
                case 1: //Login process
                    Console.Clear();
                    
                    var (username, password) = UserData.GatherLoginData();
                    
                    try
                    {
                        var (user, login) = LoginController.Login(username, password);

                        loggedUser = user;
                        if (login == true)
                        {
                            logged = true;
                        }
                        else
                        {
                            StandardMessages.FailedLogin();
                            StandardMessages.PressKeyContinueMessage();
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
                    var newUser = Factory.CreateUser();
                    
                    newUser = UserData.GatherNewUserData(newUser);
                
                    var userValidator = ValidateUser.Validate(newUser);
                    
                    if (userValidator == false) 
                    {
                        StandardMessages.PressKeyContinueMessage();
                        break;
                    }
                    
                    try
                    {
                        userValidator = NewUserController.Registration(newUser);
                        if (userValidator == false)
                        {
                            StandardMessages.UsernameInUse(newUser.Username);
                            StandardMessages.PressKeyContinueMessage();
                            break;
                        }
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine($"ERROR: {ex.Message} ");
                        StandardMessages.PressKeyContinueMessage();
                        break;
                    }
                    
                    StandardMessages.UserCreatedSuccessfully();
                    StandardMessages.PressKeyContinueMessage();
                    break;
                }
            }

            if (logged != true) return; //Inverted if to reduce nesting
            //UserData.GatherCommand();
            
            
            
            var apiKey = loggedUser.Apikey;
            
            Console.Clear();
            Menus.CommandsMenu();
            decision = GetMenuDecision.ExpectIntegerMenu(1, 1);

            switch (decision)
            {
                case 1:
                    var itemLocations =  SearchCommand.Item("Black Lion Chest", apiKey);
                    Console.Clear();
                    CommandsOutput.WriteSearchItem(itemLocations);
                    break;
            }
            
            //CommandsHandler.Do("search ", apiKey);
        }
    }
}