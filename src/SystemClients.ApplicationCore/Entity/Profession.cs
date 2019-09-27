using System;
using System.Collections.Generic;
using System.Text;

namespace SystemClients.ApplicationCore.Entity
{
    public class Profession
    {
        public Profession()
        {

        }

        public int ProfessionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CBO { get; set; }
        public ICollection<ProfessionClient> ProfessionClients { get; set; }
    }
}
