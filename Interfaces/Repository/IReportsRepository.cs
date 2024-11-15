using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IReportsRepository
    {
        List<SPResult> ExecuteSP(DateTime date1, DateTime date2);
        List<ReportData> ReportTar( );
    }
}
