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
            decision = GetMenuDecision.ExpectIntegerMenu(1, 2);

            switch (decision)
            {
                case 1: //Search for an item in the account
                    var itemLocations =  SearchCommand.Item("Pile of Bloodstone Dust", apiKey);
                    Console.Clear();
                    CommandsOutput.WriteSearchItem(itemLocations);
                    break;
                
                case 2: //Convert rate from gems and gold
                    Menus.CurrencyConverterMenu();
                    decision = GetMenuDecision.ExpectIntegerMenu(1, 2);

                    switch (decision)
                    {
                        //Convert gold to gems rate
                        case 1:
                        {
                            var gold = UserData.GatherGold();
                            var result = CurrencyConverterCommands.GoldToGems(gold);
                            CommandsOutput.WriteGoldToGemsExchange(result);
                            break;
                        }
                        case 2:
                        {
                            var gems = UserData.GatherGems();
                            var result = CurrencyConverterCommands.GemsToGold(gems);
                            CommandsOutput.WriteGoldToGemsExchange(result);
                            break;
                        }
                    }
                    break;
                case 3:
                    
                    
                    break;
            }
            
        }
    }
}