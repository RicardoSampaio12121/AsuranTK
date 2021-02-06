using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidUserPasswordException : Exception
    {
        public InvalidUserPasswordException() : base(string.Format("Invalid password: password must have " +
                                                                   "more than 8 and less than 20 characters")) {}

        public InvalidUserPasswordException(string message)  : base(message) {}

        public InvalidUserPasswordException(string message, Exception inner) : base(message, inner) {}

    }
}