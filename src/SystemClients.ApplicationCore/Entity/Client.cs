﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemClients.ApplicationCore.Entity
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Client()
        {

        }
    }
}
