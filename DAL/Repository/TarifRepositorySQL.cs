using BLL.Models;
using DomainModel;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TarifRepositorySQL : IRepository<tariff>
    {
        private UserContext db;

        public TarifRepositorySQL(UserContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<tariff> GetList()
        {
            return db.tariff.ToList();
        }

        public tariff GetItem(int id)
        {
            return db.tariff.Find(id);
        }

        public void Create(tariff tar)
        {
            db.tariff.Add(tar);
        }

        public void Update(tariff tar)
        {
            db.Entry(tar).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            tariff tar = db.tariff.Find(id);
            if (tar != null)
                db.tariff.Remove(tar);
        }


    }
}
