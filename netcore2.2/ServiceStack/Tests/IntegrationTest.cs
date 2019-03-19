using NUnit.Framework;
using ServiceStack.ServiceModel.Types.Message;
using ServiceStack.ServiceModel.Types.Message.Request;

namespace ServiceStack.Tests
{
    public class IntegrationTest
    {
        private const string BaseUri = "http://localhost:2000/";
        private readonly ServiceStackHost _appHost;

        public IntegrationTest()
        {
            _appHost = new AppHost()
                .Init()
                .Start(BaseUri);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => _appHost.Dispose();

        public IServiceClient CreateClient() => new JsonServiceClient(BaseUri);

        [Test]
        public void ReturnsMessageOnGetRequest()
        {
            var client = CreateClient();
            var message = client.Get(new Get { Id = 1 });

            Assert.Equals(message, new Message(1, ""));
        }
    }
}