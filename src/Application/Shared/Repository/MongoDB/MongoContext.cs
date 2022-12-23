using MongoDB.Driver;

namespace Application.Shared.Repository.MongoDB
{
    public class MongoContext : IMongoContext
    {
        private readonly MongoClient _mongoClient;
        public MongoContext(string cnnString)
        {
            _mongoClient = new MongoClient(cnnString);
        }

        public IMongoDatabase GetCustomerDB() =>
            _mongoClient.GetDatabase(Databases.Customer);
    }
}
