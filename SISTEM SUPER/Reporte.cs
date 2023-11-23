using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public  class Reporte
	{
		private CD_Reporte objcd_reporte = new CD_Reporte();

		public List<ReporteCompra> Compra (string fechainicio, string fechafin, int idproveedor)
		{
			return objcd_reporte.Compra(fechainicio, fechafin, idproveedor);
		}

		public List<ReporteVenta> venta (string fechainicio, string fechafin)
		{
			return objcd_reporte.Venta(fechainicio, fechafin);
		}

	}
}
