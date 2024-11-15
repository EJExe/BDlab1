
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class USER
    {
        public int ID_user { get; set; }

        public string fio { get; set; }

        public string phone_number { get; set; }
        public int ID_tariff { get; set; }
        public string typeofuser { get; set; }
       
        public USER() { }
        public USER(User p)
        {
            ID_user = p.ID_User;
            fio = p.FIO;
            phone_number = p.Phone_Number;
            ID_tariff = p.ID_Tariff_FK_;
            typeofuser = p.TypeOfUser;
            
        }
    }
}
