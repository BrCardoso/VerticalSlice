using Application.Shared.Domain.Models;
using System.Threading;

namespace Application.Features.CreateCustomer.Repository
{
    public interface ICreateCustomerRepository
    {
        void Create(CustomerModel input, CancellationToken cancelationToken);
    }
}