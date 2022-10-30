﻿using Interview.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Interview.API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<UriShortenerDBContext>(c =>
            c.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));
       

        return services;
    }
}
