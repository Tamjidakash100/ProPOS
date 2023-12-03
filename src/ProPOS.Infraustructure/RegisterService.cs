using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProPOS.Infraustructure.Persistence;

namespace ProPOS.Infraustructure;

public static class RegisterService
{
    public static IServiceCollection InfrastructureConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProPOSContext>(x =>
            x.UseSqlServer(configuration.GetConnectionString("DbConn")));
        return services;
    }
}