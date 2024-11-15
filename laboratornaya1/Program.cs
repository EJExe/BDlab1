using DIApp.Util;
using Interfaces.Services;
using laboratornaya1.Util;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratornaya1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var kernel = new StandardKernel(new NinjectRegistrarion(), new ReposModule("dbUsers"));

            IUserService userServ = kernel.Get<IUserService>();
            ITarifService tarifServ = kernel.Get<ITarifService>();
            IReportService reportServ = kernel.Get<IReportService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(userServ, tarifServ, reportServ));
        }
    }
}
