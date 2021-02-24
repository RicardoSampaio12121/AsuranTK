using System;

namespace Exceptions
{
    /// <summary>
    /// Exception for when there is a problem opening the database
    /// </summary>
    public class OpenDatabaseException : Exception
    {
        public OpenDatabaseException() : base(string.Format("There was an error trying to establish connection" +
                                                            "to the database.")) {}

        public OpenDatabaseException(string message)  : base(message) {}

        public OpenDatabaseException(string message, Exception inner) : base(message, inner) {}
    }
}