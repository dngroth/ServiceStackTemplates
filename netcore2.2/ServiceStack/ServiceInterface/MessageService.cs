using ServiceStack.ServiceModel;
using ServiceStack.ServiceModel.Message;
using ServiceStack.ServiceModel.Message.Request;

namespace ServiceStack.ServiceInterface
{
    public class MessageService : Service
    {
        // temp implementation
        private readonly IRepository<Message> _repository;

        public MessageService(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public object Get(GetAll request)
        {
            return _repository.GetAll();
        }

        public object Get(Get request)
        {
            return _repository.Get(request.Id);
        }

        public object Post(Create request)
        {
            var message = new Message(0, request.Name);

            return _repository.Insert(message.Id, message)
                ? message
                : null;
        }

        public object Put(Update request)
        {
            var message = new Message(request.Id, request.Name);

            return _repository.Update(request.Id, message)
                ? message
                : null;
        }

        public void Delete(Delete request)
        {
            _repository.Delete(request.Id);
        }
    }
}