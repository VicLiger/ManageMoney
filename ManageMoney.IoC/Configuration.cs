﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Repositories;
using ManageMoney.Application.Interfaces;
using ManageMoney.Application.Services;
using ManageMoney.Application.Mappings;

namespace ManageMoney.IoC
{
    public static class Configuration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Connection"),
                d => d.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            // Correções nas interfaces e nomes das classes
            services.AddScoped<IAccountCashRepository, AccountCashRepository>();
            services.AddScoped<IConsumptionRepository, ConsumptionRepository>(); // Correção de nome
            services.AddScoped<IFinancialObjectiveRepository, FinancialObjectiveRepository>();
            services.AddScoped<IInvestimentRepository, InvestimentRepository>(); // Correção de nome
            services.AddScoped<IUserRepository, UserRepository>();


            services.AddScoped<IAccountCashService, AccountCashService>();
            services.AddScoped<IConsumptionService, ConsumptionService>();
            services.AddScoped<IFinancialObjectiveService, FinancialObjectiveService>();
            services.AddScoped<IInvestimentService, InvestimentService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(DomainDTOMappingProfile));


            return services;
        }
    }
}
