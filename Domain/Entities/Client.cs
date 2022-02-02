using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class Client
    {
        public Guid ClientId { get; set; }

        public string ClientName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string phone { get; set; }

        public string address { get; set; }
    }
}
