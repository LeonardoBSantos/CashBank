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

        public Wallet GetWalletById(Guid id)
        {
            var wallet = _digitalAccountContext.Wallets.Find(id);

            if(wallet == null)
            {
                throw new InvalidOperationException("The provided id doesn't exists");
            }

            return wallet;
        }

        public Wallet CreateWalletByClientId(Guid ClientId)
        {
            var newWallet = new Wallet()
            {
                FkClientId = ClientId
            };

            _digitalAccountContext.Wallets.Add(newWallet);
            _digitalAccountContext.SaveChanges();

            return newWallet;
        }

        
        public void DeleteWallet(Guid ClientId)
        {
            var wallet = _digitalAccountContext.Wallets.FirstOrDefault(x => x.FkClientId == ClientId);
            
            if (wallet == null)
            {
                throw new Exception("Client id not exists");
            }

            _digitalAccountContext.Wallets.Remove(wallet);
            _digitalAccountContext.SaveChanges();
        }
    }
}
