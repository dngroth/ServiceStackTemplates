using ServiceStack.ServiceInterface.Message;
using ServiceStack.ServiceInterface.Message.Request;
using ServiceStack.ServiceModel;
using ServiceStack.ServiceModel.Message;
using Xunit;

namespace ServiceStack.App.Test
{
    public class IntegrationTests
    {
        private const string BaseUri = "http://localhost:2000/";
        private readonly ServiceStackHost _appHost;

        public IntegrationTests()
        {
            _appHost = new AppHost()
                .Init()
                .Start(BaseUri);

            // Todo: register data model instead of memory dummy
            _appHost.Container.RegisterAs<MemoryRepository<Message>, IRepository<Message>>();
            _appHost.Container.AddTransient<MessageService>();
        }

        public IServiceClient CreateClient() => new JsonServiceClient(BaseUri);

        [Fact]
        public void ReturnsMessageOnGetRequest()
        {
            var client = CreateClient();
            var messages = client.Get(new GetMessages());

            Assert.Equal(new Message[0], messages);
        }
    }
}
