namespace ServiceStack.ServiceModel
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public Hello(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
