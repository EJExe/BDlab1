using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class SPResult
    {
        public int ID_Call { get; set; }
        public int Amount { get; set; }
        public string Phones { get; set; }
        public DateTime Time_of_start { get; set; }

    }
    public class ReportData
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
