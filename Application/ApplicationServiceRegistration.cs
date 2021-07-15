using Application.Activities;
using Application.Core;
using BL;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddExtendedApplicationServices(this IServiceCollection services, IConfiguration config) {
            services.AddMediatR(typeof(List.Handler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddBusinessServices(config);
            return services;
        }
    }
}