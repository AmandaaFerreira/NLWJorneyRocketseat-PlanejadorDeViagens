using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class ErrorOnValidationException : JourneyException
    {

        private readonly IList<string> _errors;

        public ErrorOnValidationException(IList<string> messages) : base(string.Empty)
        {
            _errors = messages;
        }

        public override IList<string> GetErrorMessages()
        {   
            return _errors;
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
