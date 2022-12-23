using Application.Features.CreateCustomer.Models.Input;
using Application.Features.CreateCustomer.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.CreateCustomer.UseCases
{
    public class CreateCustomerUseCase : IRequestHandler<CreateCustomerInput, bool>
    {
        private readonly ICreateCustomerRepository _repo;

        public CreateCustomerUseCase(ICreateCustomerRepository repo)
        {
            _repo = repo;
        }

        public Task<bool> Handle(CreateCustomerInput request, CancellationToken cancellationToken)
        {
            _repo.Create(request.ToCreateModel(), cancellationToken);
            return Task.FromResult(true);
        }
    }
}
