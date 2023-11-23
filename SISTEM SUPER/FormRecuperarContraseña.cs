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
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new UserModel(); // instanciamos modelo de usuario
            var result = user.recuperacionContraseña(txtRequerimientoUsuario.Text); // delcaramos variable para resultado 
            lblResultado.Text = result;

        }
    }
}
