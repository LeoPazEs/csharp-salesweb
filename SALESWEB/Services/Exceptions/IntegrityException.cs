using System;

namespace SALESWEB.Services.Exceptions
{
    public class IntegrityException: ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
