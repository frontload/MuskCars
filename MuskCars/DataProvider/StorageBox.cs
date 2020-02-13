using MuskCars.Entities;

namespace MuskCars.DataProvider
{
    public class StorageBox
    {
        public IStorage<User> Users { get; private set; }
        public IStorage<CarWorkshop> CarWorkshops { get; private set; }
        public ApptStorage Appointments { get; private set; }
        private static StorageBox storageBox { get; set; }
        private StorageBox()
        {
            Users = new Storage<User>();
            CarWorkshops = new Storage<CarWorkshop>();
            Appointments = new ApptStorage();
        }

        public static StorageBox GetInstance()
        {
            if (storageBox == null)
                storageBox = new StorageBox();
            return storageBox;
        }
    }
}
