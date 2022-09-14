using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class WalletModel
    {
        [JsonProperty("wallet_id")]
        public int WalletId { get; set; }

        [JsonProperty("wallet_amout")]
        public Decimal WalletAmount { get; set; }

        [JsonProperty("fk_client_id")]
        public Guid FkClientId { get; set; }
    }
}
