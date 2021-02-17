using System;
using BusinessObjects.User;
using Logic.Application;
using ValidateUser = ConsoleUI.Validations.ValidateUser;
using Factory = BusinessObjects.Factory;


namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            bool logged = false;
            IUser loggedUser = Factory.CreateUser();
            
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
                        var values = LoginController.Login(username, password);

                        var login = values.success;
                        loggedUser = values.user;
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
                    IUser newUser = Factory.CreateUser();
                    
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

            if (logged != true) return; //Inverted if to reduce nesting
            //UserData.GatherCommand();
            
            
            
            string apiKey = loggedUser.Apikey;
            //TestController.Test(apiKey);
            
            /*HttpClient _client = new HttpClient();
            
            _client.DefaultRequestHeaders.Clear();
            //_client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            
            string requestUri = @"http://www.gw2spidy.com/api/v0.9/json/item-search/Mystic%20Coin";
            var stringTask = _client.GetAsync(requestUri);
            stringTask.Wait();
            var result = stringTask.Result;
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);*/
            
            CommandsHandler.Do("search +1 Agony Infusion", apiKey);
        }
    }
}