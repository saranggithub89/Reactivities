using Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{

  public static class ApplicationServicesExtensions
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
    IConfiguration config)
    {
      services.AddSwaggerGen(c =>
    {
      c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    });
      // services.AddDbContext<DataContext>(opt =>
      // {
      //   opt.UseNpgsql(config.GetConnectionString("DefaultConnection"));
      // });
      services.AddCors(opts =>
      {
        opts.AddPolicy("CorsPolicy", policy =>
        {
          policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
        });
      });
      
      // services.AddMediatR(Assembly.GetCallingAssembly());
      // services.AddAutoMapper(typeof(MappingProfiles).Assembly);
      services.AddExtendedApplicationServices(config);
      // services.AddTransient<IActivityService, ActivityService>();
      // services.AddTransient<IActivityRepository, ActivityRepository>();
      return services;
    }
  }
}