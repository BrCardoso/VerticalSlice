using Application.Features.CreateCustomer.Models.Input;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator= mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateCustomerInput input, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(input, cancellationToken));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(UpdateCustomerInput input, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(input, cancellationToken));
        }

    }
}
