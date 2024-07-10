namespace Journey.Exception.ExceptionsBase
{
    public abstract class JourneyException : SystemException
    {
        public JourneyException(string message) : base(message)
        {
            
        }

    }
}
