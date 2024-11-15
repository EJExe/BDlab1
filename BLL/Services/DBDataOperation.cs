using DomainModel;
using Interfaces.Models;
using Interfaces.Models.Models;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBDataOperation : ITarifService
    {
        private IDbRepos db;
        public DBDataOperation(IDbRepos repos)
        {
            db = repos;
        }
        public DBDataOperation()
        {
            
        }
        public List<TARIFF> GetTARIFFS()
        {
            return db.tariff.GetList().Select(i => new TARIFF(i)).ToList();
        }


        public TARIFF GetTARIF(int Id)
        {
            return new TARIFF(db.tariff.GetItem(Id));
        }

        public void CreateTARIFF(TARIFF p)
        {
            db.tariff.Create(new tariff() { ID_Tariff = p.ID_Tariff, Name = p.Name, Price = p.Price, TypeOfTariff = p.typeoftariff });
            Save();
            //db.User.Attach(p);
        }

        public void UpdateTar(TARIFF p)
        {
            tariff ph = db.tariff.GetItem(p.ID_Tariff);
            ph.Name = p.Name;
            ph.Price = p.Price;
            ph.TypeOfTariff = p.typeoftariff;
            Save();
        }

        public void DeleteTar(int id)
        {
            tariff p = db.tariff.GetItem(id);
            if (p != null)
            {
                db.tariff.Delete(p.ID_Tariff);
                Save();
            }
        }


        public bool Save()
        {
            if (db.Save() > 0) return true;
            else return false;
        }

        public List<USER> GetUSRS()
        {
            return db.user.GetList().Select(i => new USER(i)).ToList();
        }

        public bool MakeTar(TARIFF tar, string textfio)
        {
            bool errorFound = false;
            string errorString = "";

            return true; 

        }

    }
}
