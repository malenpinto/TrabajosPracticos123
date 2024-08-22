using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajosPracticos123.TPractico1;
using TrabajosPracticos123.TPractico2;
using TrabajosPracticos123.TPractico3;

namespace TrabajosPracticos123
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Practico1());
            //Application.Run(new Practico2());
            //Application.Run(new Practico3());
            Application.Run(new MDIParent1());

        }
    }
}
