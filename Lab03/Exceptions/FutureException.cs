using System;

namespace Lab03.Exceptions
{
    class FutureException : Exception
    {
        public FutureException(string message)
        : base(message)
        { }
    }
}
