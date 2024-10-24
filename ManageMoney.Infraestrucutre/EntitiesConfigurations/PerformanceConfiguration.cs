using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    internal class PerformanceConfiguration : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            builder.ToTable("Performances");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Date)
                .IsRequired();

            builder.Property(p => p.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(p => p.Investiment)
                .WithMany()
                .HasForeignKey(p => p.InvestimentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
