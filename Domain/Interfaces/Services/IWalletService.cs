using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IWalletService
    {
        public void CreateWalletByClientId(Guid clientId);
    }
}
