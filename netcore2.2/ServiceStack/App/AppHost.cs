using Funq;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.Message;

namespace ServiceStack.App
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(ServiceInfo.Name, typeof(ServiceInfo).Assembly) { }

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