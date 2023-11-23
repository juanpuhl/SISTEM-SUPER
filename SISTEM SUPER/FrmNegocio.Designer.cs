namespace SISTEM_SUPER
{
	partial class FrmNegocio
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
			this.txtNombreNegocio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.btnExaminar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombreNegocio
			// 
			this.txtNombreNegocio.Location = new System.Drawing.Point(23, 59);
			this.txtNombreNegocio.Name = "txtNombreNegocio";
			this.txtNombreNegocio.Size = new System.Drawing.Size(308, 20);
			this.txtNombreNegocio.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "NOMBRE DEL NEGOCIO:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 25);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(168, 25);
			this.label11.TabIndex = 4;
			this.label11.Text = "Datos Negocio:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDireccion);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCuit);
			this.groupBox1.Controls.Add(this.btnExaminar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombreNegocio);
			this.groupBox1.Controls.Add(this.picLogo);
			this.groupBox1.Location = new System.Drawing.Point(12, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(724, 289);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Green;
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnGuardar.Image = global::SISTEM_SUPER.Properties.Resources.save_file;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(564, 249);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(154, 34);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "ACTUALIZAR";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "TELEFONO:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(23, 235);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(308, 20);
			this.txtTelefono.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "DIRECCIÓN:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(23, 176);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(308, 20);
			this.txtDireccion.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "CUIL/CUIT:";
			// 
			// txtCuit
			// 
			this.txtCuit.Location = new System.Drawing.Point(23, 115);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(308, 20);
			this.txtCuit.TabIndex = 9;
			// 
			// btnExaminar
			// 
			this.btnExaminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExaminar.FlatAppearance.BorderSize = 0;
			this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExaminar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnExaminar.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExaminar.Location = new System.Drawing.Point(564, 176);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(154, 34);
			this.btnExaminar.TabIndex = 7;
			this.btnExaminar.Text = "EXAMINAR";
			this.btnExaminar.UseVisualStyleBackColor = false;
			this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(561, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "LOGO:";
			// 
			// picLogo
			// 
			this.picLogo.Location = new System.Drawing.Point(564, 39);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(154, 130);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 6;
			this.picLogo.TabStop = false;
			// 
			// FrmNegocio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label11);
			this.Name = "FrmNegocio";
			this.Text = "FrmNegocio";
			this.Load += new System.EventHandler(this.FrmNegocio_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombreNegocio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCuit;
		private System.Windows.Forms.Button btnExaminar;
		private System.Windows.Forms.Button btnGuardar;
	}
}