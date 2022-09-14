using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IWalletService
    {
        public WalletModel GetWalletById(Guid id);
        public WalletModel CreateWalletByClientId(Guid clientId);
        public void DeleteWalletById(Guid clientId);
    }
}
