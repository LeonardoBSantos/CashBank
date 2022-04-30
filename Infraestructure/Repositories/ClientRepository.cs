using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DigitalAccountContext _digitalAccountContext;

        public ClientRepository(DigitalAccountContext digitalAccountContext)
        {
            this._digitalAccountContext = digitalAccountContext;
        }

        public Client GetClientById(string id)
        {
            var clients = _digitalAccountContext.Clients.FirstOrDefault(x => x.ClientId.ToString() == id);

            return clients;
        }

        public Client CreateClient(ClientModel clientModel)
        {
            var client = new Client()
            {
                ClientName = clientModel.ClientName,
                LastName = clientModel.LastName,
                Email = clientModel.Email,
                phone = clientModel.Phone,
                address = clientModel.Address
            };

            _digitalAccountContext.Add(client);

            _digitalAccountContext.SaveChanges();

            return client;
        }
        //public Client UpdateClient()
        //{

        //}
        //public void DeleteClient()
        //{

        //}
    }
    }
