using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ClientModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? FkWalletId { get; set; }
    }
}
