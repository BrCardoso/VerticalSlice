using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Application.Shared.Repository.MongoDB
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public MongoContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _mongoDatabase = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<T> GetCustomerCollection<T>() =>
            _mongoDatabase.GetCollection<T>(Databases.Customer);
    }
}
