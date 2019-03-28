using ServiceStack.ServiceInterface.Message;
using ServiceStack.ServiceInterface.Message.Request;
using ServiceStack.ServiceModel;
using ServiceStack.Testing;
using Xunit;

namespace ServiceStack.ServiceInterface.Test
{
    public class MessageTest
    {
        private readonly ServiceStackHost _appHost;

        public MessageTest()
        {
            _appHost = new BasicAppHost().Init();
            _appHost.Container.RegisterAs<MemoryRepository<ServiceModel.Message.Message>, IRepository<ServiceModel.Message.Message>>();
            _appHost.Container.AddTransient<MessageService>();
        }

        [Fact]
        public void ReturnsMessageOnGetRequest()
        {
            var service = _appHost.Container.Resolve<MessageService>();

            var messages = service.Get(new GetMessages());

            Assert.Equal(new ServiceModel.Message.Message[0], messages);
        }
    }
}
