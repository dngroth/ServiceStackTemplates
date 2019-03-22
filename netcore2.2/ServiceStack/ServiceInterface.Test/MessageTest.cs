using ServiceStack;
using ServiceStack.ServiceInterface.Message;
using ServiceStack.ServiceInterface.Message.Request;
using ServiceStack.ServiceModel;
using ServiceStack.ServiceModel.Message;
using ServiceStack.Testing;
using Xunit;

namespace Interface.Test
{
    public class MessageTest
    {
        private readonly ServiceStackHost _appHost;

        public MessageTest()
        {
            _appHost = new BasicAppHost().Init();
            _appHost.Container.RegisterAs<MemoryRepository<Message>,IRepository<Message>>();
            _appHost.Container.AddTransient<MessageService>();
        }

        [Fact]
        public void ReturnsMessageOnGetRequest()
        {
            var service = _appHost.Container.Resolve<MessageService>();
            var message = service.Get(new GetMessages());

            Assert.Equal(message, new Message(1, ""));
        }
    }
}
