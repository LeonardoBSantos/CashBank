using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;

namespace ApplicationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController: ControllerBase
    {
        public LoginController()
        {

        }

        [HttpPost]
        public IActionResult login([FromBody] LoginModel loginModel)
        {
            if (string.IsNullOrEmpty(loginModel.userName))
                throw new Exception();
            
            return Ok();
        }
    }
}
