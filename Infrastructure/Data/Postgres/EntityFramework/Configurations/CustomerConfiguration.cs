using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.AccountBalance).IsRequired();
            builder.Property(c => c.ContactInfo);

            // Transactions ile ilişkilendirme (bire çok) müşteri işlem geçmişi
            builder.HasMany(c => c.Transactions)
                .WithOne(t => t.Customer)
                .HasForeignKey(t => t.UserId);

            // SentTransactions ile bire-çok ilişkilendirme
            builder.HasMany(c => c.SentTransactions)
                .WithOne(t => t.SenderCustomer)
                .HasForeignKey(t => t.SenderCustomerId)
                .OnDelete(DeleteBehavior.Restrict); // Opsiyonel: Silme davranışını belirle

            // ReceivedTransactions ile bire-çok ilişkilendirme
            builder.HasMany(c => c.ReceivedTransactions)
                .WithOne(t => t.ReceiverCustomer)
                .HasForeignKey(t => t.ReceiverCustomerId)
                .OnDelete(DeleteBehavior.Restrict); // Opsiyonel: Silme davranışını belirle


        }
    }
}
