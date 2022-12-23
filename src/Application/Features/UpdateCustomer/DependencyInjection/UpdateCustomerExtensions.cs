using Application.Features.UpdateCustomer.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Features.UpdateCustomer.DependencyInjection
{
    public static class UpdateCustomerExtensions
    {
        public static IServiceCollection AddUpdateCustomer(this IServiceCollection services)
        {
            services.AddScoped<IUpdateCustomerRepository, UpdateCustomerRepository>();
            return services;
        }
    }
}
