using NUnit.Framework;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceModel.Message;
using ServiceStack.ServiceModel.Message.Request;
using ServiceStack.Testing;

namespace ServiceStack.Tests
{
    public class UnitTest
    {
        private readonly ServiceStackHost _appHost;

        public UnitTest()
        {
            _appHost = new BasicAppHost().Init();
            _appHost.Container.AddTransient<MessageService>();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => _appHost.Dispose();

        [Test]
        public void ReturnsMessageOnGetRequest()
        {
            var service = _appHost.Container.Resolve<MessageService>();
            var message = service.Get(new Get { Id = 1 });

            Assert.Equals(message, new Message(1, ""));
        }
    }
}
