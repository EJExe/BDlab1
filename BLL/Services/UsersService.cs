using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UsersService
    {
        private Users db;
        public UsersService()
        {
            db = new Users();
        }

        public List<USER> GetUsers()
        {
            return db.User.ToList().Select(i => new USER(i)).ToList();
        }


        public USER GetUser(int Id)
        {
            return new USER(db.User.Find(Id));
        }

        public void CreateUser(USER p)
        {
            db.User.Add(new User() { FIO = p.fio, Phone_Number = p.phone_number, ID_Tariff_FK_ = p.ID_tariff,TypeOfUser=p.typeofuser});
            Save();
            //db.User.Attach(p);
        }

        public void UpdateUsers(USER p)
        {
            User ph = db.User.Find(p.ID_user);
            ph.FIO = p.fio;
            ph.Phone_Number = p.phone_number;
            ph.ID_Tariff_FK_ = p.ID_tariff;
            ph.TypeOfUser = p.typeofuser;
            Save();
        }

        public void DeleteUser(int id)
        {
            User p = db.User.Find(id);
            if (p != null)
            {
                db.User.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<CALLS> GetCALLS()
        {
            return db.call.ToList().Select(i => new CALLS(i)).ToList();
        }
    }
}
