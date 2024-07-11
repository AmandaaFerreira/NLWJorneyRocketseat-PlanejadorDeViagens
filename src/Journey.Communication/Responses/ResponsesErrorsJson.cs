namespace Journey.Communication.Responses
{
    public class ResponsesErrorsJson
    {
        public IList<string> Errors { get; set; } = [];

        public ResponsesErrorsJson(IList<string> errors)
        {
            Errors = errors;
        }
    }
}
    