using Models;

namespace Repositories
{
    public interface IStoreRepository
    {
        bool Insert(Store store);

        List<Store> GetAll();
    }
}
