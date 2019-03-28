namespace ServiceStack.ServiceInterface.Message.Request
{
    [Route("/messages", "POST")]
    public class CreateMessage : IReturn<ServiceModel.Message.Message>
    {
        public string Name { get; set; }
    }
}