namespace ServiceStack.ServiceModel.Types.Message.Request
{
    [Route("/messages/{Id}", "PUT")]
    public class Update : IReturn<Message>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}