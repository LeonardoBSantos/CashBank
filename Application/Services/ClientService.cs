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
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            this._clientRepository = clientRepository;
        }

        public List<ClientModel> GetAllClients()
        {
            var clients = _clientRepository.GetClients();

            var clientsList = clients.Select(x => new ClientModel()
            {
                //ClientId = x.ClientId,
                ClientName = x.ClientName,
                LastName = x.LastName,
                Email = x.Email,
                //FkWalletId = x.FkWalletId
            }).ToList();

            return clientsList;
        }
    }
}
