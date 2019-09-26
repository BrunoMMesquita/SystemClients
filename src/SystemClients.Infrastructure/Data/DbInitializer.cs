using System.Linq;
using SystemClients.ApplicationCore.Entity;

namespace SystemClients.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClientContext context)
        {
            if (context.Clients.Any())
                return;

            var clientes = new Client[]
            {
                new Client
                {
                    Nome = "Dino ",
                    Cpf = "78578945874"
                },
                new Client
                {
                    Nome = "Fran",
                    Cpf = "65936578952"
                }
            };

            context.AddRange(clientes);

            var contacts = new Contact[]
            {
                new Contact
                {
                    Name = "Contato 1",
                    Telefone = "222222",
                    Email = "algumacoisa@teste.com",
                    Client = clientes[0]
                },
                 new Contact
                {
                    Name = "Contato 2",
                    Telefone = "222222",
                    Email = "algumacoisa@teste.com",
                    Client = clientes[1]
                }
            };

            context.AddRange(contacts);

            context.SaveChanges();
        }
    }
}
