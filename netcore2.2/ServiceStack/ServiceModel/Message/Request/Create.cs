namespace ServiceStack.ServiceModel.Message.Request
{
    [Route("/messages", "POST")]
    public class Create : IReturn<Message>
    {
        public string Name { get; set; }
    }
}