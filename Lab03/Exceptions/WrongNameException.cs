using System;

namespace Lab03.Exceptions
{
    class WrongNameException : Exception
    {
        public WrongNameException(string message)
        : base(message)
        { }
    }
}
