using Application.ViewModels;
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
        public static ClientViewModel Map(Client client)
        {
            var response = new ClientViewModel()
            {
                ClientName = client.ClientName,
                LastName = client.LastName,
                Email = client.Email,
                Phone = client.phone,
                Address = client.address
            };

            return response;
        }
    }
}
