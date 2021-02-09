﻿using System;

namespace Exceptions
{
    public class ExecuteNonQueryException : Exception
    {
        public ExecuteNonQueryException() : base(string.Format("There was an error trying to operate the database.")) {}

        public ExecuteNonQueryException(string message)  : base(message) {}

        public ExecuteNonQueryException(string message, Exception inner) : base(message, inner) {}
    }
}