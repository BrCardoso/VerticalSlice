using Application.Features.CreateCustomer.Models.Input;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.CreateCustomer.UseCases
{
    public class CreateCustomerUseCase : IRequestHandler<CreateCustomerInput, bool>
    {
        public Task<bool> Handle(CreateCustomerInput request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
