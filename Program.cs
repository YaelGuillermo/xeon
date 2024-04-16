using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Models;
using Xeon.Presenters;
using Xeon.Repositories;
using Xeon.Views;
using System.Configuration;

namespace Xeon
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // connectionString
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["Xeon.Properties.Settings.SqlConnection"].ConnectionString;
            IVMain view = new FormPrincipal();
            new PMain(view, sqlConnectionString);
            Application.Run((Form) view);
        }
    }
}
