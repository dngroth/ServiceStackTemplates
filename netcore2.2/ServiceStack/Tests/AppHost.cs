using Funq;
using ServiceStack.ServiceInterface;

namespace ServiceStack.Tests
{
    internal class AppHost : AppSelfHostBase
    {
        public AppHost() : base(nameof(IntegrationTest), typeof(HelloServices).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }
}