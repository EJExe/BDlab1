using DomainModel;
using Interfaces.Models;
using Interfaces.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IDbRepos
    {
        IRepository<User> user {  get;}
        IRepository<tariff> tariff { get; }
        IRepository<call> call { get; }
        IReportsRepository Reports { get; }
        int Save();

    }
}
