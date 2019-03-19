namespace ServiceStack.ServiceModel.Types.Message.Request
{
    [Route("/messages", "POST")]
    public class Create : IReturn<Message>
    {
        public string Name { get; set; }
    }
}