using Funq;
using ServiceStack.ServiceInterface.Message;

namespace ServiceStack.App.Test
{
    internal class AppHost : AppSelfHostBase
    {
        public AppHost() : base(nameof(IntegrationTests), typeof(MessageService).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }
}
