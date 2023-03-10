using System;
using Application.Shared.Domain.Models;
using MediatR;

namespace Application.Features.CreateCustomer.Models.Input
{
    public class CreateCustomerInput : IRequest<bool>
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime Birth { get; set; }
        public GenderEnum Gender { get; set; }

        internal CustomerModel ToCreateModel() =>
            new CustomerModel
            {
                Birth = this.Birth,
                Document = this.Document,
                Gender = this.Gender,
                Id = Guid.NewGuid(),
                Name = this.Name
            };
    }
}
