using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ManageMoney.Infraestrucutre.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Consumption> AccountCashe { get; set; }
        public DbSet<Consumption> Consumption { get; set; }
        public DbSet<FinancialObjective> FinancialObjective { get; set; }
        public DbSet<Investiment> Investiment { get; set; }
        public DbSet<Performance> Performance { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
