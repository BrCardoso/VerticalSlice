using Application.Features.CreateCustomer.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Features.CreateCustomer.DependencyInjection
{
    public static class CreateCustomerExtensions
    {
        public static IServiceCollection AddCreateCustomer(this IServiceCollection services)
        {
            services.AddScoped<ICreateCustomerRepository, CreateCustomerRepository>();
            return services;
        }
    }
}
