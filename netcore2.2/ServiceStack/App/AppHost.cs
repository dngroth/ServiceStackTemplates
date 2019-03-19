using Funq;
using ServiceStack.ServiceInterface;

namespace ServiceStack.App
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("ServiceStack", typeof(MessageService).Assembly) { }

        // Configure your AppHost with the necessary configuration and dependencies your App needs
        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                DefaultRedirectPath = "/metadata",
                DebugMode = AppSettings.Get(nameof(HostConfig.DebugMode), false)
            });
        }
    }
}