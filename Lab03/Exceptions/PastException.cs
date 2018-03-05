using System;

namespace Lab03.Exceptions
{
    class PastException : Exception
    {
        public PastException(string message)
        : base(message)
        { }
    }
}
