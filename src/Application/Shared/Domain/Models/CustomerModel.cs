using System;

namespace Application.Shared.Domain.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime Birth { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
