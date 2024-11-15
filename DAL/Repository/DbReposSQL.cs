using BLL.Models;
using DomainModel;
using Interfaces.Models;
using Interfaces.Models.Models;
using Interfaces.Repository; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private UserContext db;
        private UserRepositorySQL userRepository;
        private CallRepositorySQL callRepository;
        private TarifRepositorySQL tarifRepository;
        private ReportRepositorySQL reportRepository;

        public DbReposSQL()
        {
            db = new UserContext();
        }

        public IRepository<User> user
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepositorySQL(db);
                return (IRepository<User>)userRepository;
            }
        }

        public IRepository<tariff> tariff
        {
            get
            {
                if (tarifRepository == null)
                    tarifRepository = new TarifRepositorySQL(db);
                return (IRepository<tariff>)tarifRepository;
            }
        }

        public IRepository<call> call
        {
            get
            {
                if (callRepository == null)
                    callRepository = new CallRepositorySQL(db);
                return (IRepository<call>)callRepository;
            }
        }

        public IReportsRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportRepositorySQL(db);
                return reportRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
