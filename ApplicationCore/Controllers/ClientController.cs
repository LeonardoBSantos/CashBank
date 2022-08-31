using Application.InputModels;
using Application.Mappings;
using Application.Services;
using Domain.DTOs;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService clientService;
        private IWalletService walletService;

        public ClientController(IClientService ClientService, IWalletService WalletService)
        {
            this.clientService = ClientService;
            this.walletService = WalletService;
        }

        [HttpGet]
        public IActionResult GetClientById([FromQuery] string id)
        {
            try
            {
                var client = clientService.GetClientById(id);
                return Ok(client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost("Create")]
        public IActionResult CreateClient([FromBody] ClientModel clientModel)
        {
            try
            {
                var client = clientService.CreateClient(clientModel);

                //walletService.CreateWalletByClientId(client.ClientId);

                return Created("", ClientMap.Map(client));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
