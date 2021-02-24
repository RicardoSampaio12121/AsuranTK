/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 06/02/2021
 */

using System;

namespace Exceptions
{
    /// <summary>
    /// Exception for when the ExecuteNonQuery sql command isn't successfully executed
    /// </summary>
    public class ExecuteNonQueryException : Exception
    {
        public ExecuteNonQueryException() : base(string.Format("There was an error trying to operate the database.")) {}

        public ExecuteNonQueryException(string message)  : base(message) {}

        public ExecuteNonQueryException(string message, Exception inner) : base(message, inner) {}
    }
}