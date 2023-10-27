using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Customer : Entity<int>
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public decimal AccountBalance { get; set; } //bakiye için
        public int UserId { get; set; }
        public ICollection<Transaction> Transactions { get; set; } // Müşteriye ait işlem geçmişi

        public ICollection<Transaction> SentTransactions { get; set; } // Müşterinin gönderdiği işlemler
        public ICollection<Transaction> ReceivedTransactions { get; set; } // Müşterinin aldığı işlemler

        // public Customer ReceiverCustomer { get; set; } // Alıcı müşteri
    }
}
