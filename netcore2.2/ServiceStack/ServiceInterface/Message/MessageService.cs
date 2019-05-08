using ServiceStack.ServiceInterface.Message.Request;
using ServiceStack.ServiceModel;

namespace ServiceStack.ServiceInterface.Message
{
    public class MessageService : Service
    {
        private readonly IRepository<ServiceModel.Message.Message> _repository;

        public MessageService(IRepository<ServiceModel.Message.Message> repository)
        {
            _repository = repository;
        }

        public object Get(GetMessages request)
        {
            return _repository.GetAll();
        }

        public object Get(GetMessage request)
        {
            return _repository.Get(request.Id);
        }

        public object Post(CreateMessage request)
        {
            var message = new ServiceModel.Message.Message(0, request.Name);

            return _repository.Insert(message.Id, message)
                ? message
                : null;
        }

        public object Put(UpdateMessage request)
        {
            var message = new ServiceModel.Message.Message(request.Id, request.Name);

            return _repository.Update(request.Id, message)
                ? message
                : null;
        }

        public void Delete(DeleteMessage request)
        {
            _repository.Delete(request.Id);
        }
    }
}
