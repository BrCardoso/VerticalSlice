using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Application.Shared.DependencyInjection
{
    public static class MediatRExtensions
    {
        public static IServiceCollection AddMediatRExtension(this IServiceCollection services)
        {
            services.AddMediatR(typeof(MediatRExtensions));
            return services;
        }
    }
}
