using ServiceStack;
using ServiceStack.ServiceInterface.Message.Request;
using ServiceStack.ServiceModel.Message;
using Xunit;

namespace App.Test
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
        }

        public IServiceClient CreateClient() => new JsonServiceClient(BaseUri);

        [Fact]
        public void ReturnsMessageOnGetRequest()
        {
            var client = CreateClient();
            var message = client.Get(new GetMessage { Id = 1 });

            Assert.Equal(new Message(1, ""), message);
        }
    }
}
