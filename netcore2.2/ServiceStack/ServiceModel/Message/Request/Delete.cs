namespace ServiceStack.ServiceModel.Message.Request
{
    [Route("/messages/{Id}", "DELETE")]
    public class Delete : IReturnVoid
    {
        public int Id { get; set; }
    }
}