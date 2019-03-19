namespace ServiceStack.ServiceModel.Types.Message.Request
{
    [Route("/messages/{Id}", "GET")]
    public class Get : IReturn<Message>
    {
        public int Id { get; set; }
    }
}