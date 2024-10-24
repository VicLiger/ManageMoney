using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    public class ConsumiptionConfiguration : IEntityTypeConfiguration<Consumption>
    {
        public void Configure(EntityTypeBuilder<Consumption> builder)
        {
            builder.ToTable("Consumption");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(c => c.Category)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Date)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(255);
        }
    }
}
