/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Exception for when the username is invalid
    /// </summary>
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