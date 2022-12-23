using Application.Shared.Domain.Models;
using System.Threading;

namespace Application.Features.UpdateCustomer.Repository
{
    public interface IUpdateCustomerRepository
    {
        void Create(CustomerModel input, CancellationToken cancelationToken);
    }
}