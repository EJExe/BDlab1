
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
    public class CallRepositorySQL : IRepository<call>
    {
        private UserContext db;

        public CallRepositorySQL(UserContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<call> GetList()
        {
            return db.call.ToList();
        }

        public call GetItem(int id)
        {
            return db.call.Find(id);
        }

        public void Create(call cal)
        {
            db.call.Add(cal);
        }

        public void Update(call cal)
        {
            db.Entry(cal).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            call cal = db.call.Find(id);
            if (cal != null)
                db.call.Remove(cal);
        }


    }
}
