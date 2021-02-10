using System;

namespace Exceptions
{
    public class UsernameAlreadyExistsException : Exception
    {
        public UsernameAlreadyExistsException() : base(string.Format("Username already exis")) {}

        public UsernameAlreadyExistsException(string message)  : base(message) {}

        public UsernameAlreadyExistsException(string message, Exception inner) : base(message, inner) {}
    }
}