
using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBDataOperation
    {
        private Users db;
        public DBDataOperation()
        {
            db = new Users();
        }

        public List<TARIFF> GetTARIFFS()
        {
            return db.tariff.ToList().Select(i => new TARIFF(i)).ToList();
        }


        public TARIFF GetTARIF(int Id)
        {
            return new TARIFF(db.tariff.Find(Id));
        }

        public void CreateTARIFF(TARIFF p)
        {
            db.tariff.Add(new tariff() { ID_Tariff = p.ID_Tariff, Name = p.Name, Price = p.Price, TypeOfTariff = p.typeoftariff });
            Save();
            //db.User.Attach(p);
        }

        public void UpdateTar(TARIFF p)
        {
            tariff ph = db.tariff.Find(p.ID_Tariff);
            ph.Name = p.Name;
            ph. Price = p.Price;
            ph.TypeOfTariff = p.typeoftariff;
            Save();
        }

        public void DeleteTar(int id)
        {
            tariff p = db.tariff.Find(id);
            if (p != null)
            {
                db.tariff.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<USER> GetUSRS()
        {
            return db.User.ToList().Select(i => new USER(i)).ToList();
        }

        public bool MakeTar(TARIFF tar,string textfio)
        {
            bool errorFound = false;
            string errorString = "";

            if (db.tariff.Any(pd => pd.Name == textfio)) 
            {
                errorFound = true;
                errorString += "Такой тариф уже существует\n";
            }

            if (!errorFound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
