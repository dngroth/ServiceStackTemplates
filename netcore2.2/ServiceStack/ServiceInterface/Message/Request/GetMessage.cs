namespace ServiceStack.ServiceInterface.Message.Request
{
    [Route("/messages/{Id}", "GET")]
    public class GetMessage : IReturn<ServiceModel.Message.Message>
    {
        public int Id { get; set; }
    }
}