using BLL;
using BLL.Services;
using Interfaces.Services;
using Ninject.Modules;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratornaya1.Util
{
    public class NinjectRegistrarion : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UsersService>();
            Bind<IReportService>().To<ReportService>();
            Bind<ITarifService>().To<DBDataOperation>();
        }
    }
}
