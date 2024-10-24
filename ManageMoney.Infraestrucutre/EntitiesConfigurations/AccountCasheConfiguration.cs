using ManageMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManageMoney.Infraestrucutre.EntitiesConfigurations
{
    public class AccountCashConfiguration : IEntityTypeConfiguration<AccountCash>
    {
        public void Configure(EntityTypeBuilder<AccountCash> builder)
        {
            builder.ToTable("AccountCash");

            builder.HasKey(ac => ac.Id);

            builder.Property(ac => ac.Name)
                .IsRequired() 
                .HasMaxLength(100); 

            builder.Property(ac => ac.Balance)
                .IsRequired() 
                .HasColumnType("decimal(18,2)"); 

            builder.HasOne(ac => ac.UserAccount)
                .WithMany() 
                .HasForeignKey(ac => ac.UserId)
                .IsRequired(); 

            builder.HasQueryFilter(ac => ac.Balance > 0); 
        }
    }
}
