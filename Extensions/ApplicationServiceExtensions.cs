﻿using API.Interfaces;
using API.Services;

namespace API.Extensions
{
	public static class ApplicationServiceExtensions
	{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IPowerCalculationService, PowerCalculationService>();

            return services;
        }
    }
}

