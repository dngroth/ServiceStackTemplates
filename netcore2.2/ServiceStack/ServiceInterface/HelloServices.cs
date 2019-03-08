using ServiceStack.ServiceModel;

namespace ServiceStack.ServiceInterface
{
    public class HelloServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse($"Hello, {request.Name}!");
        }
    }
}
