using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Exceptions;

namespace Logic.Validations
{
    public static class NewUserValidations
    {
        public static void Username(string username)
        {
            if (!Regex.IsMatch(username, "^[a-z0-9A-Z].*?$"))
                throw new InvalidUsernameException(username);
        }

        public static void Password(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                throw new InvalidUserPasswordException();
        }
    }
}