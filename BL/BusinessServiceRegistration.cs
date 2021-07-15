using BL.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Repositories;

namespace BL
{
  public static class BusinessServiceRegistration
  {
    public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration config)
    {
      services.AddTransient<IActivityService, ActivityService>();
      services.AddTransient<IActivityRepository, ActivityRepository>();
      services.AddPersistenceServices(config);
      return services;
    }
  }
}