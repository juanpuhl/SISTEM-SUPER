namespace SISTEM_SUPER
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelEditClient = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnEditarCliente = new System.Windows.Forms.Button();
			this.btnGuardarCambioCliente = new System.Windows.Forms.Button();
			this.btnBorrarCliente = new System.Windows.Forms.Button();
			this.cboClientes = new System.Windows.Forms.ComboBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCuil = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelEditClient.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(411, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "REGISTRO DE CLIENTES";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(85, 284);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(943, 298);
			this.dataGridView1.TabIndex = 1;
			// 
			// panelEditClient
			// 
			this.panelEditClient.Controls.Add(this.groupBox1);
			this.panelEditClient.Location = new System.Drawing.Point(64, 49);
			this.panelEditClient.Name = "panelEditClient";
			this.panelEditClient.Size = new System.Drawing.Size(989, 229);
			this.panelEditClient.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGuardarCambioCliente);
			this.groupBox1.Controls.Add(this.btnEditarCliente);
			this.groupBox1.Controls.Add(this.btnBorrarCliente);
			this.groupBox1.Controls.Add(this.cboClientes);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtCiudad);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtDireccion);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtTel);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCuil);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDni);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(81, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(867, 219);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Editar Datos Clientes";
			// 
			// btnEditarCliente
			// 
			this.btnEditarCliente.BackColor = System.Drawing.Color.DimGray;
			this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditarCliente.FlatAppearance.BorderSize = 0;
			this.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEditarCliente.Image = global::SISTEM_SUPER.Properties.Resources.save_edit;
			this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditarCliente.Location = new System.Drawing.Point(681, 23);
			this.btnEditarCliente.Name = "btnEditarCliente";
			this.btnEditarCliente.Size = new System.Drawing.Size(176, 40);
			this.btnEditarCliente.TabIndex = 2;
			this.btnEditarCliente.Text = "EDITAR";
			this.btnEditarCliente.UseVisualStyleBackColor = false;
			this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
			// 
			// btnGuardarCambioCliente
			// 
			this.btnGuardarCambioCliente.BackColor = System.Drawing.Color.DarkBlue;
			this.btnGuardarCambioCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarCambioCliente.FlatAppearance.BorderSize = 0;
			this.btnGuardarCambioCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGuardarCambioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarCambioCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarCambioCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnGuardarCambioCliente.Image = global::SISTEM_SUPER.Properties.Resources.save_file;
			this.btnGuardarCambioCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarCambioCliente.Location = new System.Drawing.Point(681, 143);
			this.btnGuardarCambioCliente.Name = "btnGuardarCambioCliente";
			this.btnGuardarCambioCliente.Size = new System.Drawing.Size(176, 41);
			this.btnGuardarCambioCliente.TabIndex = 3;
			this.btnGuardarCambioCliente.Text = "GUARDAR";
			this.btnGuardarCambioCliente.UseVisualStyleBackColor = false;
			this.btnGuardarCambioCliente.Click += new System.EventHandler(this.btnGuardarCambioCliente_Click);
			// 
			// btnBorrarCliente
			// 
			this.btnBorrarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnBorrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBorrarCliente.FlatAppearance.BorderSize = 0;
			this.btnBorrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnBorrarCliente.Image = global::SISTEM_SUPER.Properties.Resources.delete_Prod;
			this.btnBorrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBorrarCliente.Location = new System.Drawing.Point(681, 82);
			this.btnBorrarCliente.Name = "btnBorrarCliente";
			this.btnBorrarCliente.Size = new System.Drawing.Size(176, 40);
			this.btnBorrarCliente.TabIndex = 3;
			this.btnBorrarCliente.Text = "ELIMINAR";
			this.btnBorrarCliente.UseVisualStyleBackColor = false;
			this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
			// 
			// cboClientes
			// 
			this.cboClientes.FormattingEnabled = true;
			this.cboClientes.Location = new System.Drawing.Point(477, 31);
			this.cboClientes.Name = "cboClientes";
			this.cboClientes.Size = new System.Drawing.Size(152, 24);
			this.cboClientes.TabIndex = 16;
			this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(198, 164);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(152, 24);
			this.txtApellido.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(125, 167);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 17);
			this.label9.TabIndex = 14;
			this.label9.Text = "APELLIDO:";
			// 
			// txtCiudad
			// 
			this.txtCiudad.Location = new System.Drawing.Point(477, 173);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(152, 24);
			this.txtCiudad.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(411, 176);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "CIUDAD:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(477, 127);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(152, 24);
			this.txtDireccion.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(388, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "DIRECCION:";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(477, 82);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(152, 24);
			this.txtTel.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(434, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "TEL:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(370, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "COND. FISCAL:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(198, 121);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(152, 24);
			this.txtNombre.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(128, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "NOMBRE:";
			// 
			// txtCuil
			// 
			this.txtCuil.Location = new System.Drawing.Point(198, 76);
			this.txtCuil.Name = "txtCuil";
			this.txtCuil.Size = new System.Drawing.Size(152, 24);
			this.txtCuil.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "CUIL:";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(198, 34);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(152, 24);
			this.txtDni.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(155, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "DNI:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(1061, 9);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 20;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// FormClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 484);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.panelEditClient);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormClientes";
			this.Text = "FormClientes";
			this.Load += new System.EventHandler(this.FormClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelEditClient.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelEditClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarCambioCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label btnCerrar;
    }
}