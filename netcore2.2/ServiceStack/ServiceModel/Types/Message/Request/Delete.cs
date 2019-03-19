namespace ServiceStack.ServiceModel.Types.Message.Request
{
    [Route("/messages/{Id}", "DELETE")]
    public class Delete : IReturnVoid
    {
        public int Id { get; set; }
    }
}