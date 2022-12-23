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
            _customerMongoCollection.ReplaceOne(
                FilterDefinition<CustomerModel>.Empty,
                input,
                new ReplaceOptions { IsUpsert = true },
                cancelationToken);
        }
    }
}
