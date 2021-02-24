using System;

namespace Exceptions
{
    /// <summary>
    /// Exception for when an username is already in use
    /// </summary>
    public class UsernameAlreadyExistsException : Exception
    {
        public UsernameAlreadyExistsException() : base(string.Format("Username already exists")) {}

        public UsernameAlreadyExistsException(string message)  : base(message) {}

        public UsernameAlreadyExistsException(string message, Exception inner) : base(message, inner) {}
    }
}