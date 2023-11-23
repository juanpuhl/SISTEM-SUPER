namespace SISTEM_SUPER
{
	partial class FrmAdminUsuarios
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
			this.CerrarVentana = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLoginUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.linkEditar = new System.Windows.Forms.LinkLabel();
			this.txtPosition = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// CerrarVentana
			// 
			this.CerrarVentana.Image = global::SISTEM_SUPER.Properties.Resources.window_close_icon_181227;
			this.CerrarVentana.Location = new System.Drawing.Point(837, -4);
			this.CerrarVentana.Name = "CerrarVentana";
			this.CerrarVentana.Size = new System.Drawing.Size(24, 25);
			this.CerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CerrarVentana.TabIndex = 34;
			this.CerrarVentana.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Controls.Add(this.btnEditar);
			this.panel1.Controls.Add(this.btnAceptar);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtPosition);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtApellido);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtLoginUser);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(423, -16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(381, 482);
			this.panel1.TabIndex = 32;
			this.panel1.Visible = false;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEditar.Location = new System.Drawing.Point(135, 395);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(112, 40);
			this.btnEditar.TabIndex = 19;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.DarkBlue;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAceptar.Location = new System.Drawing.Point(253, 395);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(112, 40);
			this.btnAceptar.TabIndex = 18;
			this.btnAceptar.Text = "Guardar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancelar.Location = new System.Drawing.Point(10, 395);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 40);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(22, 299);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(273, 20);
			this.txtPassword.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label8.Location = new System.Drawing.Point(22, 236);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Posicion:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label7.Location = new System.Drawing.Point(22, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Contraseña:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(25, 212);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(273, 20);
			this.txtEmail.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label6.Location = new System.Drawing.Point(22, 191);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Email:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(25, 168);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(273, 20);
			this.txtApellido.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label5.Location = new System.Drawing.Point(22, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Apellido:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(25, 124);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(273, 20);
			this.txtNombre.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Location = new System.Drawing.Point(22, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre:";
			// 
			// txtLoginUser
			// 
			this.txtLoginUser.Location = new System.Drawing.Point(25, 80);
			this.txtLoginUser.Name = "txtLoginUser";
			this.txtLoginUser.Size = new System.Drawing.Size(273, 20);
			this.txtLoginUser.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(22, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Login Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(5, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 28);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos de Usuarios:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 30);
			this.label1.TabIndex = 20;
			this.label1.Text = "Usuarios del Sistema:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(405, 385);
			this.dataGridView1.TabIndex = 35;
			// 
			// linkEditar
			// 
			this.linkEditar.AutoSize = true;
			this.linkEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkEditar.Location = new System.Drawing.Point(278, 19);
			this.linkEditar.Name = "linkEditar";
			this.linkEditar.Size = new System.Drawing.Size(118, 20);
			this.linkEditar.TabIndex = 36;
			this.linkEditar.TabStop = true;
			this.linkEditar.Text = "Editar Usuarios";
			this.linkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditar_LinkClicked);
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(25, 256);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(273, 20);
			this.txtPosition.TabIndex = 10;
			// 
			// FrmAdminUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.linkEditar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.CerrarVentana);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "FrmAdminUsuarios";
			this.Text = "Administrar Usuarios del Sistema";
			this.Load += new System.EventHandler(this.FrmAdminUsuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.CerrarVentana)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox CerrarVentana;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLoginUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.LinkLabel linkEditar;
		private System.Windows.Forms.TextBox txtPosition;
	}
}