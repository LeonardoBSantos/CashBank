using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IWalletRepository
    {
        public Wallet GetWalletById(Guid id);
        public Wallet CreateWalletByClientId(Guid ClientId);
        public void DeleteWallet(Guid ClientId);
    }
}
