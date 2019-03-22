using Funq;
using ServiceStack;
using ServiceStack.ServiceInterface.Message;

namespace App.Test
{
    internal class AppHost : AppSelfHostBase
    {
        public AppHost() : base(nameof(IntegrationTests), typeof(MessageService).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }
}