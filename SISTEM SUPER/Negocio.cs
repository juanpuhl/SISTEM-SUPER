using Patagames.Pdf.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public class Negocio
	{
		private CD_Negocio objcd_negocio = new CD_Negocio();
		public int IdNegocio { get; set; }
		public string Nombre { get; set; }

		public string Cuit { get; set; }
		public string Direccion { get; set; }

		public string Telefono { get; set; }


		public Negocio ObetnerDatos()
		{
			return objcd_negocio.DatosNegocio();

		}

		public bool GuardarDatos(Negocio obj, out string mensaje)
		{
			mensaje = string.Empty;

			if (obj.Nombre == "")
			{
				mensaje += "Es necesario ingresar el Nombre del Negocio\n";
			}

			if (obj.Cuit == "")
			{
				mensaje += "Es necesario ingresar Cuit\n";
			}

			if (obj.Direccion == "")
			{
				mensaje += "Es necesario ingresar una dirección\n";
			}

			if (obj.Telefono == "")
			{
				mensaje += "Es necesario ingresar un teléfono\n";
			}

			// Verifica si hay mensajes y devuelve false si hay mensajes de validación
			if (!string.IsNullOrEmpty(mensaje))
			{
				return false;
			}
			else
			{
				// Si no hay mensajes de validación, llama al método objcd_negocio.GuardarDatos
				// y asigna el mensaje de retorno a la variable 'mensaje'
				return objcd_negocio.GuardarDatos(obj, out mensaje);
			}
		}

		public byte[] Logo(out bool obtenido) // obtner logo
		{
			return objcd_negocio.Logo(out obtenido);

		}

		public bool ActulizarLogo(byte[] imagen, out string mensaje) // obtner logo
		{
			return objcd_negocio.ActualizarLogo(imagen, out mensaje);

		}
	} 
}