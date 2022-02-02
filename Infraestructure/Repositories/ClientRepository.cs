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

        public List<Client> GetClients()
        {
            var clients = _digitalAccountContext.Clients.ToList();

            return clients;
        }

        //public Client CreateClient()
        //{

        //}
        //public Client UpdateClient()
        //{

        //}
        //public void DeleteClient()
        //{

        //}
        }
    }
