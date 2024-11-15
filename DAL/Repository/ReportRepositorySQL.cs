using DomainModel; 
using Interfaces.Models;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ReportRepositorySQL : IReportsRepository
    {
        private UserContext db;
        
        public ReportRepositorySQL(UserContext dbcontext)
        {
            this.db = dbcontext;
        }

        //выполнить ХП
        public List<SPResult> ExecuteSP(DateTime date1, DateTime date2)
        {
            SqlParameter param1 = new SqlParameter("@StartTime", date1);
            SqlParameter param2 = new SqlParameter("@EndTime", date2);
            UserContext dbcontext = new UserContext();

            var result = dbcontext.Database.SqlQuery<SPResult>("GetCallsByTimeRange @StartTime,@EndTime", new object[] { param1, param2 }).ToList();
            var data = result.GroupBy(i => new { i.ID_Call, i.Time_of_start }).ToDictionary(i => i.Key, i => i.Select(j => j.Amount))
                .Select(i => new SPResult
                {
                    ID_Call = i.Key.ID_Call,
                    Time_of_start = i.Key.Time_of_start,
                    Phones = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();
            return data;

        }

        public List<ReportData> ReportTar()
        {
            UserContext dbcontext = new UserContext();
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
