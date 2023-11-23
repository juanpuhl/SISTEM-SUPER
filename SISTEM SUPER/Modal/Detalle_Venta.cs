using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER.Modal
{
	public  class Detalle_Venta
	{
		public Productos Productos { get; set; }
		public decimal PrecioVenta { get; set; }
		public int Cantidad { get; set; }
		public decimal SubTotal { get; set; }
	}
}
