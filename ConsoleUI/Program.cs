using System;
using BusinessObjects.User;
using ConsoleUI.Validations;
using Logic.Application;
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
                    
                    newUser = UserData.Gather(newUser);

                    bool validator = ValidateUser.Validate(newUser);

                    if (ValidateIsFalseHandler.Validate(validator) == false) break;
                    
                    validator = NewUserController.Registration(newUser);

                    if (ValidateIsFalseHandler.Validate(validator) == false) break;
                    
                    StandardMessages.UserCreatedSuccessfully();
                    StandardMessages.PressKeyContinueMessage();
                    Console.ReadKey();

                    break;
                }
            }
        }
    }
}