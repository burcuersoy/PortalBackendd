using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Transaction : Entity<int> 
    {
        public decimal Amount { get; set; } //miktar
        public string Date { get; set; }
        public Customer Customer { get; set; }
        public int UserId { get; set; }
        //public User SenderUser{ get; set; } // Gönderen kullanıcı 
        // public User ReceiverUser { get; set; } // Eğer kullanıcılar arası transferse alıcı kullanıcı
        public Customer SenderCustomer { get; set; } // Gönderen müşteri
        public Customer ReceiverCustomer { get; set; } // Alıcı müşteri
        public int SenderCustomerId { get; set; } // Gönderen müşterinin ID'si
        public int ReceiverCustomerId { get; set; } // Alıcı müşterinin ID'si

        //public Customer SenderCustomer { get; set; }
        // public Customer ReceiverCustomer { get; set; }

    }
}
