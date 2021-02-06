/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 * Resume: This file contains exceptions for when the user inputs an invalid username when
 *         making a registration
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException()
        {

        }

        public InvalidUsernameException(string message) : base($"Invalid username: {message}")
        {
            
        }

        public InvalidUsernameException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}