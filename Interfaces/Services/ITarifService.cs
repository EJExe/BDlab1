
using Interfaces.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface ITarifService
    {
        //Создает или изменяет существующий заказ
        bool MakeTar(TARIFF tARIFF, string textfio);
        List<TARIFF> GetTARIFFS();
        TARIFF GetTARIF(int Id);
        void DeleteTar(int id);
    }
}
