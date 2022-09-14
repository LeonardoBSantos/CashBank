using Application.ViewModels;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class ClientMap
    {
        public static ClientViewModel Map(Client client, WalletModel wallet)
        {
            var response = new ClientViewModel()
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                LastName = client.LastName,
                Email = client.Email,
                Phone = client.phone,
                Address = client.address,
                Wallet = wallet
            };

            return response;
        }
    }
}
