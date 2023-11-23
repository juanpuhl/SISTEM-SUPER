using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public partial class FormClientes : Form
    {

        Clientes objetoClientes = new Clientes();
        private string idCliente = null; // para que no ocupe lugar en memoria
        private bool EditClient = false;


        public FormClientes()
        {
            InitializeComponent();
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarCondicionFiscal();
            MostrarClientes();


        }

        private void MostrarClientes()
        {

            Clientes objetoC = new Clientes();
            dataGridView1.DataSource = objetoC.MostrarClientes();
        }

        private void CargarCondicionFiscal()
        {
            //cargar combox condicion fiscal Cliente
            cboClientes.Items.Add("Seleccionar");
            cboClientes.Items.Add("Consumidor Final");
            cboClientes.Items.Add("Monotributista");
            cboClientes.Items.Add("Resp. Inscripto");
            cboClientes.SelectedIndex = 0;
        }

        private void btnGuardarCambioCliente_Click(object sender, EventArgs e)
        {
            //INSERTAR CLIENTE
            if (EditClient == false)
            {
                try
                {
                    objetoClientes.InsertarCliente(idCliente, txtDni.Text, txtCuil.Text, txtNombre.Text, txtApellido.Text, cboClientes.Text, txtTel.Text, txtDireccion.Text, txtCiudad.Text);
                    MessageBox.Show("Se INSERTO correctamente Cliente");
                    MostrarClientes();
                    LimpiarForm();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo INSERTAR Cliente por: " + ex.Message);

                }
            }

            //EDITAR CLIENTE
            if (EditClient == true)
            {
                try
                {
                    objetoClientes.EditarCliente(idCliente, txtDni.Text, txtCuil.Text, txtNombre.Text, txtApellido.Text, cboClientes.Text, txtTel.Text, txtDireccion.Text, txtCiudad.Text);
                    MessageBox.Show("Se EDITO correctamente Cliente");
                    MostrarClientes();
                    LimpiarForm();
                    EditClient = false;
                }
                catch (Exception ex )
                {
                    MessageBox.Show("No se pudo EDITAR  Cliente por: " + ex.Message);
                }

            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditClient = true;
                txtDni.Text = dataGridView1.CurrentRow.Cells["Dni"].Value.ToString();
                txtCuil.Text = dataGridView1.CurrentRow.Cells["Cuil"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                cboClientes.Text = dataGridView1.CurrentRow.Cells["Condicion_Fiscal"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCiudad.Text = dataGridView1.CurrentRow.Cells["Ciudad"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["id"].Value.ToString(); 
            }
            else
                MessageBox.Show("Seleccione la fila a editar");
        }
        private void LimpiarForm()
        {
            txtDni.Clear();
            txtCuil.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cboClientes.SelectedIndex = 0;
            txtTel.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton eliminar
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoClientes.EliminarCliente(idCliente);
                    MessageBox.Show("Cliente ELIMINADO correctamente");
                    MostrarClientes();
                }


            }
            else
                MessageBox.Show("Seleccione la fila para ELIMINAR");
        }
    }
}
