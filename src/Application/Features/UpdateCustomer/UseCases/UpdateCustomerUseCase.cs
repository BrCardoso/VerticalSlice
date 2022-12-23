using Application.Features.UpdateCustomer.Models.Input;
using Application.Features.UpdateCustomer.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.UpdateCustomer.UseCases
{
    public class UpdateCustomerUseCase : IRequestHandler<UpdateCustomerInput, bool>
    {
        private readonly IUpdateCustomerRepository _repo;

        public UpdateCustomerUseCase(IUpdateCustomerRepository repo)
        {
            _repo = repo;
        }

        public Task<bool> Handle(UpdateCustomerInput request, CancellationToken cancellationToken)
        {
            _repo.Create(request.ToCreateModel(), cancellationToken);
            return Task.FromResult(true);
        }
    }
}
