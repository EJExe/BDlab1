using DomainModel; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models.Models
{
    public class CALLS
    {
        public int ID_call { get; set; }

        public DateTime Time_of_start { get; set; }

        public int Amount { get; set; }

        public CALLS() { }
        public CALLS(call p)
        {
            ID_call = p.ID_Call;
            Time_of_start = (DateTime)p.Time_of_start;
            Amount = p.Amount;
        }
    }
}
