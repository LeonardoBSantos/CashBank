using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class WalletRepository: IWalletRepository
    {
        private DigitalAccountContext _digitalAccountContext;

        public WalletRepository(DigitalAccountContext digitalAccountContext)
        {
            this._digitalAccountContext = digitalAccountContext;
        }

        public void CreateWalletByClientId(Guid ClientId)
        {
            var newWallet = new Wallet()
            {
                FkClientId = ClientId
            };

            _digitalAccountContext.Wallets.Add(newWallet);
            _digitalAccountContext.SaveChanges();
        }
    }
}
