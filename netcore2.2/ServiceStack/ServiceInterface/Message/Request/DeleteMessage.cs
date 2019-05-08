namespace ServiceStack.ServiceInterface.Message.Request
{
    [Route("/messages/{Id}", "DELETE")]
    public class DeleteMessage : IReturnVoid
    {
        public int Id { get; set; }
    }
}
