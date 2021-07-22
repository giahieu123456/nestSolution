using System;
using System.Collections.Generic;
using System.Text;

namespace nestSolution.Utilities.Exceptions
{
    class nestException : Exception
    {
        public nestException()
        {
        }

        public nestException(string message)
            : base(message)
        {
        }

        public nestException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
