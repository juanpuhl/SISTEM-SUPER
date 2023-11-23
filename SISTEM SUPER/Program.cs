using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using SISTEM_SUPER.Modal;

namespace SISTEM_SUPER
{
    internal static class Program
    {
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
        {
            //pone region de argentina
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-Ar");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			
			Application.Run(new FormLogin());
			//Application.Run(new FrmReporteVentas());
			


		}
	}
}
