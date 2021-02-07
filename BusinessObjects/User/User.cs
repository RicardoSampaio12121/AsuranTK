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

namespace BusinessObjects.User
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Apikey { get; set; }
    }
}