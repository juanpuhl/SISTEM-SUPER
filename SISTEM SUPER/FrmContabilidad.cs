using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public partial class FrmContabilidad : Form
    {
        public FrmContabilidad()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var FrmEmpleados = new FrmEmpleados();
            FrmEmpleados.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FrmInformeStockProductos = new FrmInformeStockProductos();
            FrmInformeStockProductos.ShowDialog();
        }

		private void btnCompras_Click(object sender, EventArgs e)
		{
			var FrmCompras = new FrmCompras();
			FrmCompras.ShowDialog();
		}

		private void btnInformeCompras_Click(object sender, EventArgs e)
		{
			var FrmDetalleCompra = new FrmDetalleCompra();
			FrmDetalleCompra.ShowDialog();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGenerarQR_Click(object sender, EventArgs e)
		{
			var FrmCrearCodigoQR = new FrmCrearCodigoQR();
			FrmCrearCodigoQR.ShowDialog();
		}

		private void btnLeerQR_Click(object sender, EventArgs e)
		{
			var FrmLeerCodigoQR = new FrmLeerCodigoQR();
			FrmLeerCodigoQR.ShowDialog();
		}

		private void btnDetalleVentas_Click(object sender, EventArgs e)
		{
			var FrmDetalleVenta = new FrmDetalleVenta();
			FrmDetalleVenta.ShowDialog();
		}
	}
}
