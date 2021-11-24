using Autofac;
using Domain.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();

            builder.RegisterType<CalendarioModel>().As<ICalendarioRepos>();
            var container = builder.Build();
            Application.Run(new FrmPrestamo(container.Resolve<ICalendarioRepos>()));
        }
    }
}
