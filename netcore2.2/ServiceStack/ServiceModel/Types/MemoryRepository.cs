using System.Collections.Generic;
using System.Linq;

namespace ServiceStack.ServiceModel.Types
{
    public class MemoryRepository<T> : IRepository<T>
    {
        private readonly Dictionary<int, T> _data;

        public MemoryRepository(Dictionary<int, T> data)
        {
            _data = data;
        }

        public IReadOnlyList<T> GetAll() => _data.Values.ToList().AsReadOnly();

        public T Get(int id)
        {
            return _data.ContainsKey(id)
                ? _data[id]
                : default(T);
        }

        public bool Insert(int id, T entry)
        {
            if (_data.ContainsKey(id))
            {
                return false;
            }

            _data.Add(id, entry);

            return true;
        }

        public bool Update(int id, T entry)
        {
            if (!_data.ContainsKey(id))
            {
                return false;
            }

            _data[id] = entry;

            return true;
        }

        public bool Delete(int id)
        {
            if (!_data.ContainsKey(id))
            {
                return false;
            }

            _data.Remove(id);

            return true;
        }
    }
}