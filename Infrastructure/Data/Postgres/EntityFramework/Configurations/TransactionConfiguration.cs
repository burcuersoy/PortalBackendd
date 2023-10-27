using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.UserId).IsRequired(); // İşlemi gerçekleştiren kullanıcı ID'si
            builder.Property(t => t.ReceiverCustomerId); // Eğer kullanıcılar arası transferse alıcı kullanıcı ID'si
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.Amount).IsRequired();

           // builder.Property(t => t.SenderUserId).IsRequired();
            builder.Property(t => t.ReceiverCustomerId).IsRequired();


            // SenderCustomer ile ilişkilendirme
            builder.HasOne(t => t.SenderCustomer)
                .WithMany(c => c.SentTransactions)
                .HasForeignKey(t => t.SenderCustomerId);

            // ReceiverCustomer ile ilişkilendirme
            builder.HasOne(t => t.ReceiverCustomer)
                .WithMany(c => c.ReceivedTransactions)
                .HasForeignKey(t => t.ReceiverCustomerId);
        }
    }
}
