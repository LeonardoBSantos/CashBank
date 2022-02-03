using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        
        public string OperationType { get; set; }
        
        public Decimal Amount { get; set; }
        
        public DateTime TransactionDate { get; set; }

        public int FkWalletId { get; set; }

        public Wallet Wallet { get; set; }
    }
}
