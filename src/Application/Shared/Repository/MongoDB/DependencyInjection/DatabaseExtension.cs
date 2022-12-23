using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Shared.Repository.MongoDB.DependencyInjection
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDatabase(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(s => new MongoContext(configuration.GetSection("mongoConnectionString").Value));
            return services;
        }
    }
}
