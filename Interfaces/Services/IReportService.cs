using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IReportService
    {
        /// <summary>
        /// выполнить ХП - отчет по заказам за месяц
        /// </summary>
        List<SPResult> ExecuteSP(DateTime date1, DateTime date2);
        /// <summary>
        /// Телефоны производителя
        /// </summary>
        List<ReportData> ReportTar();
    }
}
