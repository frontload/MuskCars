using MuskCars.DataProvider;
using MuskCars.Entities;
using System.Collections.Generic;

namespace MuskCars.BusinessLogic
{
    public class UserBL : IEntityProvider<User>
    {
        private IStorage<User> users;
        public UserBL()
        {
            users = StorageBox.GetInstance().Users;
        }
        public void Add(User item)
        {
            if (users.ExistsKey(item.Id)
                || users.CountByPropertValue(i => i.UserName == item.UserName) > 0
                || users.CountByPropertValue(i => i.Email == item.Email) > 0)
                return;
            users.Add(item);
        }

        public bool Delete(int id)
            => users.Delete(id);

        public User Get(int id)
            => users.Get(id);

        public IEnumerable<User> GetAll()
            => users.GetAll();
    }
}
