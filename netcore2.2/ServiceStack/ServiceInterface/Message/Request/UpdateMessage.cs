namespace ServiceStack.ServiceInterface.Message.Request
{
    [Route("/messages/{Id}", "PUT")]
    public class UpdateMessage : IReturn<ServiceModel.Message.Message>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
