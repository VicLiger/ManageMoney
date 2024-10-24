
using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    internal class InvestimentConfiguration : IEntityTypeConfiguration<Investiment>
    {
        public void Configure(EntityTypeBuilder<Investiment> builder)
        {
        }
    }
}
