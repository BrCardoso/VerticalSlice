using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Shared.Repository.MongoDB.DependencyInjection
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<MongoSettings>(
                configuration.GetSection("Mongo"));
            services.AddSingleton<IMongoContext, MongoContext>();
            return services;
        }
    }
}
