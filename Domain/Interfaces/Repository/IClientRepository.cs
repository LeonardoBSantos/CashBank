using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IClientRepository
    {
        public Client GetClientByEmail(string email);
        public Client GetClientById(string id);
        public Client CreateClient(ClientModel clientModel);
        //Client UpdateClient();
        public void DeleteClient(Guid id);
    }
}
