using SIS.HTTP.Enums;
using System;

namespace SIS.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {
        private const string DefaultMessage = "The Request was malformed or contains unsupported elements.";

        public HttpResponseStatusCode StatusCode => HttpResponseStatusCode.BadRequest;

        public BadRequestException() : base(DefaultMessage)
        {
        }
    }
}
