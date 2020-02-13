using System.Collections.Generic;

namespace MuskCars.BusinessLogic
{
    public interface IEntityProvider<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        bool Delete(int id);
    }
}
