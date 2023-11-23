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
    public partial class StockRegistro : Form
    {
        Productos objetoProd = new Productos();
        private string idProducto = null; //creo variable null para q no ocupe valor en memoria
        private bool Editar=false; 
        public StockRegistro()
        {
            InitializeComponent();
        }

        private void StockRegistro_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Productos objeto = new Productos(); //para que se actualice
            dataGridView1.DataSource = objeto.MostrarProd();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar productos
            if (Editar == false) //agrega el registro
            {
                try
                {

                    objetoProd.InsertarProductos(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecioCom.Text, txtPrecioVenta.Text, txtStock.Text);
                    MessageBox.Show("Se INSERTO correctamente");
                    MostrarProductos();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO se pueden insertar los datos por: " + ex.Message);
                }
            } 
            //editar productos
            if (Editar == true) // edita el regitro
            {
                try
                {
                    objetoProd.EditarProductos(idProducto, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecioCom.Text, txtPrecioVenta.Text, txtStock.Text);
                    MessageBox.Show("Se EDITO correctamente");
                    MostrarProductos();
                    LimpiarForm();
                    Editar=false; // cambia a falso para que el boton siga agregando registro

                }
                catch(Exception ex)
                {
                    MessageBox.Show("NO se pueden EDITAR los datos por: " + ex.Message);
                }
            } 


        }

        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Editar=true; // al cumplirse la condicion del if la variable editar pasa a verdadero
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo_Producto"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecioCom.Text = dataGridView1.CurrentRow.Cells["Precio_Compra"].Value.ToString();
                txtPrecioVenta.Text = dataGridView1.CurrentRow.Cells["Precio_Venta"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto= dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else //al no cumplirse la condicion le decimos al usuario que elija la fila a editar
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }
        private void LimpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecioCom.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoProd.ElimarProducto(idProducto);
                MessageBox.Show("Eliminado Correctamente");
                MostrarProductos();
            }
            else //al no cumplirse la condicion le decimos al usuario que elija la fila a editar
            {
                MessageBox.Show("Seleccione la fila a editar");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
