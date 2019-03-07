using ServiceStack.ServiceModel;

namespace ServiceStack.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse($"Hello, {request.Name}!");
        }
    }
}
