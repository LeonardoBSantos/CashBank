using Application.Services;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using Xunit;

namespace CashBank_Tests
{
    public class CreateClientTest
    {
        private readonly ClientService clientService;

        public CreateClientTest()
        {
            this.clientService = new ClientService(new Mock<IClientRepository>().Object);
        }

        [Fact]
        public void Get_ClientById()
        {
            var id = "3622EF13-EF8C-4C94-C309-08DA56E9B627";

            clientService.GetClientById(id);
            //Assert.ThrowsAny<Exception>(() => clientService.CreateClient(model));
            var exception = Record.Exception(() => clientService.GetClientById(id));
            Assert.Null(exception);
        }

        [Fact]
        public void Post_Create_Client()
        {
            var model = new ClientModel()
            {
                ClientName = "Leonardo",
                LastName = "Santos",
                Email = "leonardo@gmail.com",
                Phone = "11974632251",
                Address = "Rua Mario Monteleone, 5660"
            };

            clientService.CreateClient(model);
            //Assert.ThrowsAny<Exception>(() => clientService.CreateClient(model));
            var exception = Record.Exception(() => clientService.CreateClient(model));
            Assert.Null(exception);
        }
    }
}
