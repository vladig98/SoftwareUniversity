using SIS.HTTP.Enums;
using System;

namespace SIS.HTTP.Exceptions
{
    public class InternalServerErrorException : Exception
    {
        private const string DefaultMessage = "The Server has encountered an error.";

        public HttpResponseStatusCode StatusCode => HttpResponseStatusCode.InternalServerError;

        public InternalServerErrorException() : base(DefaultMessage)
        {
        }
    }
}
