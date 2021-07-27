using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomisedException : Exception
    {
        ExceptionType exceptionType;
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, INVALID_MESSAGE, NVALID_FIELD, METHOD_NOT_FOUND
        }
        public CustomisedException(ExceptionType exception, string message) : base(message)
        {
            this.exceptionType = exception;
        }
    }
}
