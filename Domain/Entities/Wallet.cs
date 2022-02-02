using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domain.Entities
{
    public class Wallet
    {
        public int WalletId { get; set; }
        
        public Decimal WalletAmount { get; set; }

        public Guid FkClientId { get; set; }

        public Client Client { get; set; }
    }
}
