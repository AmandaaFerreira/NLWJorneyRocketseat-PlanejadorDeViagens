using System.Net;

namespace Journey.Exception.ExceptionsBase;

public abstract class JourneyException : SystemException
{
    public JourneyException(string message) : base(message)
    {

    }

    public abstract HttpStatusCode GetStatusCode();

    public abstract IList<string> GetErrorMessages();

}
