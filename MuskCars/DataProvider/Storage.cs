using MuskCars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MuskCars.DataProvider
{
    public class Storage<T> : IStorage<T> where T : IHasId
    {
        public Storage()
        {
            storage = new Dictionary<int, T>();
        }

        protected Dictionary<int, T> storage { get; set; }
        public int Count => storage.Count;

        public T Get(int id)
            => storage.TryGetValue(id, out var value) ? value : default;

        public void Add(T item)
        {
            var obj = new Object();
            lock (obj) {
                item.Id = storage.Count();
                storage.Add(item.Id, item);
            }
        }

        public bool Delete(int id)
        {
            if (!storage.ContainsKey(id))
                return true;
            storage.Remove(id);
            return !storage.ContainsKey(id);
        }

        public bool ExistsKey(int id)
            => storage.ContainsKey(id);

        public int CountByPropertValue(Func<T, bool> predicate)
            =>  storage.Values.Where(predicate).Count();

        public IEnumerable<T> GetAll()
            => storage.Values.ToList();
    }
}
