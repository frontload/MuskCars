using System;
using System.Collections.Generic;

namespace MuskCars.DataProvider
{
    public interface IStorage<T>
    {
        int Count { get;}
        T Get(int id);
        void Add(T item);
        bool Delete(int id);
        bool ExistsKey(int id);
        int CountByPropertValue(Func<T, bool> predicate);
        public IEnumerable<T> GetAll();
    }
}
