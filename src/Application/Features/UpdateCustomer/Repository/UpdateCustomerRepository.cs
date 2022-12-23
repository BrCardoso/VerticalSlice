using Application.Shared.Domain.Models;
using Application.Shared.Repository.MongoDB;
using MongoDB.Driver;
using System.Threading;

namespace Application.Features.UpdateCustomer.Repository
{
    public class UpdateCustomerRepository : IUpdateCustomerRepository
    {
        private readonly IMongoCollection<CustomerModel> _customerMongoCollection;

        public UpdateCustomerRepository(MongoContext mongoContext)
        {
            _customerMongoCollection = mongoContext.GetCustomerCollection<CustomerModel>();
        }

        public void Create(CustomerModel input, CancellationToken cancelationToken)
        {
            FilterDefinition<CustomerModel> filter = Builders<CustomerModel>.Filter.Where(c => c.Id == input.Id);

            _customerMongoCollection.ReplaceOneAsync(
                filter,
                input,
                new ReplaceOptions { IsUpsert = true },
                cancelationToken);
        }
    }
}
