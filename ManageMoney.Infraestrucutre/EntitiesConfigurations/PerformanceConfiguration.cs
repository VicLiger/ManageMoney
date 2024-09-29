
using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    internal class PerformanceConfiguration : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            throw new NotImplementedException();
        }
    }
}
