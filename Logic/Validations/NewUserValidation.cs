﻿using System.Text.RegularExpressions;

namespace Logic.Validations
{
    public static class NewUserValidations
    {
        public static bool Username(string username)
        {
            return Regex.IsMatch(username, "^[a-z0-9A-Z].*?$");
        }

        public static bool Password(string password)
        {
            return password.Length >= 8 && password.Length <= 20;
        }
    }
}