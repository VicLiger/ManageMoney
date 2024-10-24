using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Repositories;

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
            services.AddScoped<IConsumptionRepository, ConsumiptionRepository>(); // Correção de nome
            services.AddScoped<IFinancialObjectiveRepository, FinancialObjectiveRepository>();
            services.AddScoped<IInvestimentRepository, InvestimentRepository>(); // Correção de nome
            services.AddScoped<IPerfomanceRepository, PerformanceRepository>(); // Correção de nome
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
