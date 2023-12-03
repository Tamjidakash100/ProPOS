﻿using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProPOS.Application.Behavior;
using ProPOS.Application.Repository;

namespace ProPOS.Application;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Scan(scan => scan.FromAssemblyOf<IApplication>()
            .AddClasses(classes => classes.AssignableTo<IApplication>())
            .AddClasses(x => x.AssignableTo(typeof(IBaseRepository<,,>)))
            .AsSelfWithInterfaces()
            .WithScopedLifetime());




        //services.AddValidatorsFromAssembly(typeof(IApplication).Assembly);
        services.AddMediatR(x =>
        {
            x.RegisterServicesFromAssemblies(typeof(IApplication).Assembly);
            x.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            x.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

        });

        services.AddAutoMapper(x => {
            x.AddMaps(typeof(IApplication).Assembly);

        });

        //services.Configure<JwtConfig>(configuration.GetSection("JwtConfig"));
    }
}