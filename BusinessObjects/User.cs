/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 04/02/2021
 * Resume: This file containt a class to store users
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Exceptions;

namespace BusinessObjects
{
    public class User
    {
        private string _userName;
        private string _password;
        private string _apikey;



        public User(string username, string password, string apikey)
        {
            _userName = username;
            _password = password;
            _apikey = apikey;
        }



        public string Username
        {
            get => _userName;
            set
            {
                if (!Regex.IsMatch(value, "^[a-z0-9A-Z].*?$"))
                {
                    throw new InvalidUsernameException(value);
                }
                else
                    _userName = value;
            }
        }

        public string Password
        {
            get => _password; 
            set
            {
                if (value.Length < 8 || value.Length > 20)
                {
                    throw new InvalidUserPasswordException();
                }
                else
                    _password = value;
            }
        }
        
        public string Apikey
        {
            get => _apikey;  
            set => _apikey = value;
        }

    }
}