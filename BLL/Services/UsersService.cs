using DomainModel;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models.Models;
using DAL;
using Interfaces.Models;

namespace Services
{
    public class UsersService : IUserService
    {
        private IDbRepos db;
        public UsersService(IDbRepos repos)
        {
            db = repos;
        }

        public List<USER> GetUsers()
        {
            return db.user.GetList().Select(i => new USER(i)).ToList();
        }


        public USER GetUser(int Id)
        {
            return new USER(db.user.GetItem(Id));
        }

        public void CreateUser(USER p)
        {
            db.user.Create(new User() {  ID_User = p.ID_user + 1,FIO = p.fio, Phone_Number = p.phone_number, ID_Tariff_FK_ = p.ID_tariff,TypeOfUser=p.typeofuser});
            Save();
            //db.User.Attach(p);
        }

        public void UpdateUsers(USER p)
        {
            User ph = db.user.GetItem(p.ID_user);
            ph.ID_User = p.ID_user;
            ph.FIO = p.fio;
            ph.Phone_Number = p.phone_number;
            ph.ID_Tariff_FK_ = p.ID_tariff;
            ph.TypeOfUser = p.typeofuser;
            Save();
        }

        public void DeleteUser(int id)
        {
            User p = db.user.GetItem(id);
            if (p != null)
            {
                db.user.Delete(p.ID_Tariff_FK_);
                Save();
            }
        }


        public bool Save()
        {
            if (db.Save() > 0) return true;
            else return false;
        }

        public List<TARIFF> GetTARIFFS()
        {
            return db.tariff.GetList().Select(i => new TARIFF(i)).ToList();
        }
    }
}
