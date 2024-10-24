using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReportService
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

        //выполнить ХП
        public static List<SPResult> ExecuteSP(DateTime date1, DateTime date2)
        {
            SqlParameter param1 = new SqlParameter("@StartTime", date1);
            SqlParameter param2 = new SqlParameter("@EndTime", date2);

            //System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@month", month);
            //System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@year", year);
            Users dbcontext = new Users();

            var result = dbcontext.Database.SqlQuery<SPResult>("GetCallsByTimeRange @StartTime,@EndTime", new object[] { param1, param2 }).ToList();
            var data = result.GroupBy(i => new { i.ID_Call, i.Time_of_start }).ToDictionary(i => i.Key, i => i.Select(j => j.Amount))
                .Select(i => new SPResult {
                    ID_Call = i.Key.ID_Call,
                    Time_of_start = i.Key.Time_of_start,
                    Phones = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();

            //var result = db.Database.SqlQuery<SPResult>("Orders_getByMonth @month,@year", new object[] { param1, param2 }).ToList();
            //var data = result.GroupBy(i => new { i.Customer, i.Date }).ToDictionary(i => i.Key, i => i.Select(j => j.PhoneName))
            //    .Select(i => new OrdersByMonth
            //    {
            //        Customer = i.Key.Customer,
            //        Date = i.Key.Date,
            //        Phones = String.Join(",", i.Value.Select(j => j).ToArray())
            //    }).ToList();
            return data;

        }

        public static List<ReportData> ReportTar( )
        {
            Users dbcontext = new Users();
            var request = dbcontext.tariff
            .Join(dbcontext.User, c => c.ID_Tariff, em => em.ID_Tariff_FK_, (c, em) => new { tariff = c, User = em })
            .Where(x => x.User.ID_Tariff_FK_ == x.tariff.ID_Tariff)
            .GroupBy(x => x.tariff.Name)
            .Select(g => new ReportData { Name = g.Key, Count = g.Count() })
            .ToList();
            return request;
        }
    }
}
