using Interfaces.Models;
using Interfaces.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IUserService

    {
        List<USER> GetUsers();
        USER GetUser(int Id);
        void CreateUser(USER p);
        void UpdateUsers(USER p);
        void DeleteUser(int id);

        List<TARIFF> GetTARIFFS();
    }
}
