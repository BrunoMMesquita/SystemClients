using System;
using System.Collections.Generic;
using System.Text;

namespace SystemClients.ApplicationCore.Entity
{
    public class Adress
    {
        public Adress()
        {

        }

        public int AdressId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
