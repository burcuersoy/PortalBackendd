using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class TransactionUpdateDto
    {
        public decimal Amount { get; set; } //miktar
        public string Date { get; set; }
        
        public int UserId { get; set; }
        public int SenderCustomerId { get; set; } // Gönderen müşterinin ID'si
        public int ReceiverCustomerId { get; set; } // Alıcı müşterinin ID'si


    }
}
