using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SISTEM_SUPER.Modal; // Reemplaza 'SISTEM_SUPER.Modal' con el espacio de nombres correcto donde se encuentra la clase Detalle_Compra


namespace SISTEM_SUPER.Modal
{
	public class Detalle_Compra
	{
		//public Productos oProducto { get; set; }
		public Productos Productos { get; set; }
		public decimal PrecioCompra { get; set; }
		public int Cantidad { get; set; }
		public decimal MontoTotal { get; set; }
	
	}


}
