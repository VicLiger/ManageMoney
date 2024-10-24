

using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    public class ConsumiptionConfiguration : IEntityTypeConfiguration<Consumption>
    {
        public void Configure(EntityTypeBuilder<Consumption> builder)
        {
        }
    }
}
