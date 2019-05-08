using System.Collections.Generic;

namespace ServiceStack.ServiceModel
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> GetAll();

        T Get(int key);

        bool Insert(int key, T value);

        bool Update(int key, T value);

        bool Delete(int key);
    }
}
