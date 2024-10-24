using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    public class FinancialObjectiveConfiguration : IEntityTypeConfiguration<FinancialObjective>
    {
        public void Configure(EntityTypeBuilder<FinancialObjective> builder)
        {
            builder.ToTable("FinancialObjectives");

            builder.HasKey(fo => fo.Id);

            builder.Property(fo => fo.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(fo => fo.Date)
                .IsRequired();

            builder.Property(fo => fo.Type)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
