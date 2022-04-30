using Domain.DTOs;
using Domain.Entities;
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
        private IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            this._clientRepository = clientRepository;
        }

        public ClientModel GetClientById(string id)
        {
            var client = _clientRepository.GetClientById(id);

            var clientById = new ClientModel()
            {
                ClientName = client.ClientName,
                LastName = client.LastName,
                Email = client.Email,
                Phone = client.phone,
                Address = client.address
            };

            return clientById;
        }

        public Client CreateClient(ClientModel clientModel)
        {
            var client = _clientRepository.CreateClient(clientModel);

            return client;
        }
    }
}
