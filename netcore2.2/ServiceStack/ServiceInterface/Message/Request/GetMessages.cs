using System.Collections.Generic;

namespace ServiceStack.ServiceInterface.Message.Request
{
    [Route("/messages", "GET")]
    public class GetMessages : IReturn<IReadOnlyList<ServiceModel.Message.Message>>
    {
    }
}