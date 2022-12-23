using System;
using Application.Shared.Domain.Models;
using MediatR;

namespace Application.Features.UpdateCustomer.Models.Input
{
    public class UpdateCustomerInput : IRequest<bool>
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime Birth { get; set; }
        public GenderEnum Gender { get; set; }
        public Guid Id { get; set; }

        internal CustomerModel ToCreateModel() =>
            new CustomerModel
            {
                Birth = this.Birth,
                Document = this.Document,
                Gender = this.Gender,
                Id = this.Id,
                Name = this.Name
            };
    }
}
