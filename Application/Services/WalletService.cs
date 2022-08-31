using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class WalletService: IWalletService
    {
        private IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            this._walletRepository = walletRepository;
        }

        public void CreateWalletByClientId(Guid clientId)
        {
            _walletRepository.CreateWalletByClientId(clientId);
        }
    }
}
