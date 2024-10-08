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
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<AppDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("DefaultConexion"),
            d => d.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IAccountCashRepository, AccountCashRepository>();
            services.AddScoped<IConsumptionRepository, ConsumiptionRepository>();
            services.AddScoped<IFinancialObjectiveRepository, FinancialObjectiveRepository>();
            services.AddScoped<IInvestimentRepository, InvestimentRepository>();
            services.AddScoped<IPerfomanceRepository, PerformanceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
