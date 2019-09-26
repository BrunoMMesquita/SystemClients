using System;
using System.Collections.Generic;
using System.Text;

namespace SystemClients.ApplicationCore.Entity
{
    public class Contact
    {
        public Contact()
        {

        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string  Email { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
