using Funq;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Message;

namespace ServiceStack.Tests
{
    internal class AppHost : AppSelfHostBase
    {
        public AppHost() : base(nameof(IntegrationTest), typeof(MessageService).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }
}