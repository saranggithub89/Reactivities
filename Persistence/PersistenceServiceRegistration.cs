using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class PersistenceRegistrationService
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration config) {
            services.AddDbContext<DataContext>(opts =>
                opts.UseNpgsql(config.GetConnectionString("DefaultConnection"))
            );
            return services;
        }
        
    }
}