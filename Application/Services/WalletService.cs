using Domain.DTOs;
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

        public WalletModel GetWalletById(Guid id)
        {
            try
            {
                var wallet = _walletRepository.GetWalletById(id);

                var walletModel = new WalletModel()
                {
                    WalletId = wallet.WalletId,
                    WalletAmount = wallet.WalletAmount,
                    FkClientId = wallet.FkClientId
                };

                return walletModel;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public WalletModel CreateWalletByClientId(Guid clientId)
        {
            var newWallet = _walletRepository.CreateWalletByClientId(clientId);

            var walletModel = new WalletModel()
            {
                WalletId = newWallet.WalletId,
                WalletAmount = newWallet.WalletAmount,
                FkClientId = newWallet.FkClientId
            };

            return walletModel;
        }

        public void DeleteWalletById(Guid clientId)
        {
            try
            {
                _walletRepository.DeleteWallet(clientId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
