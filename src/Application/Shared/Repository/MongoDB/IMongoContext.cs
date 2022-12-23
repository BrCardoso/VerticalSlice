using MongoDB.Driver;

namespace Application.Shared.Repository.MongoDB
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCustomerCollection<T>();
    }
}