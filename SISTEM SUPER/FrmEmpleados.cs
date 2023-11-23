using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging; //Clase imagen
using System.IO; // para los archivos en memoria 
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using System.Net.Mime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISTEM_SUPER
{
    public partial class FrmEmpleados : Form
    {

        
        Empleados objetoEmpleados = new Empleados();
        private string idEmpleado = null; // para que no ocupe lugar en memoria
        private bool EditEmpleado = false;

        public FrmEmpleados()
        {
            InitializeComponent();
            CargarEstadoCivil();
            CargarGenero();
            CargarCargo();
            MostrarEmpleados();
        }

       
        //cargar combox el estado civil
        private void CargarEstadoCivil()
        {
           
            cmboEstadoCivil.Items.Add("Seleccionar");
            cmboEstadoCivil.Items.Add("Soltero");
            cmboEstadoCivil.Items.Add("Casado");
            cmboEstadoCivil.Items.Add("Divorciado");
            cmboEstadoCivil.Items.Add("Viudo");
            cmboEstadoCivil.SelectedIndex = 0;
        }
        //cargar combox el cargo
        private void CargarCargo()
        {
          
            cmboCargo.Items.Add("Seleccionar");
            cmboCargo.Items.Add("Gerente");
            cmboCargo.Items.Add("Cajero");
            cmboCargo.Items.Add("Administrativo");
            cmboCargo.Items.Add("Atencion al Cliente");
            cmboCargo.Items.Add("Repositor");
            cmboCargo.SelectedIndex = 0;
        }

        //cargar combox el genero
        private void CargarGenero()
        {
           
            cmboGenero.Items.Add("Seleccionar");
            cmboGenero.Items.Add("Masculino");
            cmboGenero.Items.Add("Femenino");
            cmboGenero.Items.Add("Otro");
            cmboGenero.SelectedIndex = 0;
        }
        //BOTON EXAMINAR Y CARGAR IMAGEN AL PICBOX

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog SeleccionarImagen = new OpenFileDialog();
            SeleccionarImagen.Filter = "Imágenes JPG (*.jpg)|*.jpg|Imágenes PNG (*.png)|*.png";
            SeleccionarImagen.Title = "Seleccionar imagen";

            if (SeleccionarImagen.ShowDialog() == DialogResult.OK) //para verificar si seleciono imagen y dio ok
            {
                picFotoEmpleado.Image = Image.FromFile(SeleccionarImagen.FileName);
                /*MemoryStream memoria = new MemoryStream();
                picFotoEmpleado.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg); // para que se guarde en jpeg

                imagenPerfil = memoria.ToArray();*/

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR CLIENTE
            if (EditEmpleado == false)
            {
                MemoryStream ms = new MemoryStream();
                picFotoEmpleado.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                try
                {
                    objetoEmpleados.InsertarEmpleado(idEmpleado, txtLegajo.Text, txtDni.Text, txtCuil.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTel.Text, cmboCargo.Text, txtDireccion.Text, cmboGenero.Text, cmboEstadoCivil.Text, txtHijos.Text, aByte);

                      MessageBox.Show("Se INSERTO correctamente Empleado");

                      MostrarEmpleados();
                      LimpiarForm();
                       
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo INSERTAR Empleado por: " + ex.Message);

                }
            }

            //EDITAR CLIENTE
            if (EditEmpleado == true)
            {
                try
                {



                    MemoryStream ms = new MemoryStream();
                    picFotoEmpleado.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    
                    objetoEmpleados.EditarEmpleados(idEmpleado, txtLegajo.Text, txtDni.Text, txtCuil.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTel.Text, cmboCargo.Text, txtDireccion.Text, cmboGenero.Text, cmboEstadoCivil.Text, txtHijos.Text, aByte);

                     MessageBox.Show("Se EDITO correctamente Empleado");
                     MostrarEmpleados();
                     LimpiarForm();
                     EditEmpleado = false;
                                            
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo EDITAR Empleado por: " + ex.Message);
                }

            }
        }

        //LIMPIAR FORMULARIO
        private void LimpiarForm()
        {
            txtLegajo.Clear();
            txtDni.Clear();
            txtCuil.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTel.Clear();
            cmboCargo.SelectedIndex = 0;
            txtDireccion.Clear();
            cmboGenero.SelectedIndex = 0;
            cmboEstadoCivil.SelectedIndex = 0;
            txtHijos.Clear();
            picFotoEmpleado.Image = null;

        }
        //para mostrar los empelados en el DataGridView
        private void MostrarEmpleados()
        {

            Empleados objetoE = new Empleados();
            dataGridView1.DataSource = objetoE.MostrarEmpleados();
            dataGridView1.Columns[13].Visible = false;


        }
        private MemoryStream ByteImage()
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[13].Value;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        


        //editar empleado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditEmpleado = true;

                txtLegajo.Text =dataGridView1.CurrentRow.Cells["Legajo"].Value.ToString();
                txtDni.Text = dataGridView1.CurrentRow.Cells["Dni"].Value.ToString();
                txtCuil.Text = dataGridView1.CurrentRow.Cells["Cuil"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                cmboCargo.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                cmboGenero.Text = dataGridView1.CurrentRow.Cells["Genero"].Value.ToString();
                cmboEstadoCivil.Text = dataGridView1.CurrentRow.Cells["EstadoCivil"].Value.ToString();
                txtHijos.Text = dataGridView1.CurrentRow.Cells["Hijos"].Value.ToString();
                idEmpleado = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

                byte[] img = (byte[])dataGridView1.CurrentRow.Cells["FotoImagen"].Value;
                if (img != null && img.Length >0)
                {
                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        Bitmap imagen = new Bitmap(ms);
                        picFotoEmpleado.Image = imagen; // Mostrar la imagen en el PictureBox
                    }
                }
                else
                {
                    // Manejo si los datos son nulos o vacíos
                    picFotoEmpleado.Image = null; // Puedes establecer una imagen predeterminada o dejar el PictureBox vacío
                }

               
            }
            else
                MessageBox.Show("Seleccione la fila a editar");
        }

        //ELIMINAR EMPLEADO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
            
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este Empleado?", "Confirmar Eliminación", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                idEmpleado = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoEmpleados.Eliminarempleado(idEmpleado);
                MessageBox.Show("Empleado ELIMINADO correctamente");
                MostrarEmpleados();
                }

            } 
              else
                MessageBox.Show("Seleccione la fila para ELIMINAR");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
