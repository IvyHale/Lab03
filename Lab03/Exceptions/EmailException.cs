using System;

namespace Lab03.Exceptions
{
    class EmailException : Exception
    {
        public EmailException(string message)
        : base(message)
        { }
    }
}
