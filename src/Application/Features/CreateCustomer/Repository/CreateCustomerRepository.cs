using Application.Shared.Domain.Models;
using Application.Shared.Repository.MongoDB;
using MongoDB.Driver;
using System.Threading;

namespace Application.Features.CreateCustomer.Repository
{
    public class CreateCustomerRepository : ICreateCustomerRepository
    {
        private readonly IMongoCollection<CustomerModel> _customerMongoCollection;

        public CreateCustomerRepository(MongoContext mongoContext)
        {
            _customerMongoCollection = mongoContext.GetCustomerCollection<CustomerModel>();
        }

        public void Create(CustomerModel input, CancellationToken cancelationToken)
        {
            _customerMongoCollection.ReplaceOne(
                FilterDefinition<CustomerModel>.Empty,
                input,
                new ReplaceOptions { IsUpsert = true },
                cancelationToken);
        }
    }
}
