using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    internal class InvestimentConfiguration : IEntityTypeConfiguration<Investiment>
    {
        public void Configure(EntityTypeBuilder<Investiment> builder)
        {
            builder.ToTable("Investments");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(i => i.Value)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(i => i.Date)
                .IsRequired();

            builder.HasOne(i => i.Performance)
                .WithMany()
                .HasForeignKey(i => i.PerfomanceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
