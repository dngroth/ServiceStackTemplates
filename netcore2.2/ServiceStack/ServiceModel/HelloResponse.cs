namespace ServiceStack.ServiceModel
{
    public class HelloResponse
    {
        public HelloResponse(string result)
        {
            Result = result;
        }

        public string Result { get; }
    }
}