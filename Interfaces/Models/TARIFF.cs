using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Interfaces.Models.Models
{
    public class TARIFF
    {
        public int ID_Tariff { get; set; }

        public string Name { get; set; }
        public string typeoftariff { get; set; }

        public int Price { get; set; }

        //public string Orderedtariffs { get; set; }
        //public List<int> OrderedtariffsIds { get; set; }

        public TARIFF() { }
        public TARIFF(tariff p)
        {
            ID_Tariff = p.ID_Tariff;
            Name = p.Name;
            Price = p.Price;
            typeoftariff = p.TypeOfTariff;
        }
    }
}
