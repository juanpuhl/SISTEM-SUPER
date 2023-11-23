namespace SISTEM_SUPER
{
	partial class FrmProveedores
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEditarProveedor = new System.Windows.Forms.Button();
			this.btnBorrarProveedor = new System.Windows.Forms.Button();
			this.btnGuardarCambioProveedor = new System.Windows.Forms.Button();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(279, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "REGISTRO DE PROVEEDORES";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.txtTel);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtCorreo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRazonSocial);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDocumento);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(49, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(707, 439);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Editar Datos Proveedores";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnEditarProveedor);
			this.panel1.Controls.Add(this.btnBorrarProveedor);
			this.panel1.Controls.Add(this.btnGuardarCambioProveedor);
			this.panel1.Location = new System.Drawing.Point(20, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 57);
			this.panel1.TabIndex = 1;
			// 
			// btnEditarProveedor
			// 
			this.btnEditarProveedor.BackColor = System.Drawing.Color.SlateGray;
			this.btnEditarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditarProveedor.FlatAppearance.BorderSize = 0;
			this.btnEditarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEditarProveedor.Image = global::SISTEM_SUPER.Properties.Resources.save_edit;
			this.btnEditarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditarProveedor.Location = new System.Drawing.Point(3, 5);
			this.btnEditarProveedor.Name = "btnEditarProveedor";
			this.btnEditarProveedor.Size = new System.Drawing.Size(176, 40);
			this.btnEditarProveedor.TabIndex = 2;
			this.btnEditarProveedor.Text = "EDITAR";
			this.btnEditarProveedor.UseVisualStyleBackColor = false;
			this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
			// 
			// btnBorrarProveedor
			// 
			this.btnBorrarProveedor.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnBorrarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBorrarProveedor.FlatAppearance.BorderSize = 0;
			this.btnBorrarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnBorrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnBorrarProveedor.Image = global::SISTEM_SUPER.Properties.Resources.delete_Prod;
			this.btnBorrarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBorrarProveedor.Location = new System.Drawing.Point(229, 5);
			this.btnBorrarProveedor.Name = "btnBorrarProveedor";
			this.btnBorrarProveedor.Size = new System.Drawing.Size(176, 40);
			this.btnBorrarProveedor.TabIndex = 3;
			this.btnBorrarProveedor.Text = "ELIMINAR";
			this.btnBorrarProveedor.UseVisualStyleBackColor = false;
			this.btnBorrarProveedor.Click += new System.EventHandler(this.btnBorrarProveedor_Click);
			// 
			// btnGuardarCambioProveedor
			// 
			this.btnGuardarCambioProveedor.BackColor = System.Drawing.Color.DarkBlue;
			this.btnGuardarCambioProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarCambioProveedor.FlatAppearance.BorderSize = 0;
			this.btnGuardarCambioProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGuardarCambioProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarCambioProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarCambioProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnGuardarCambioProveedor.Image = global::SISTEM_SUPER.Properties.Resources.save_file;
			this.btnGuardarCambioProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarCambioProveedor.Location = new System.Drawing.Point(467, 4);
			this.btnGuardarCambioProveedor.Name = "btnGuardarCambioProveedor";
			this.btnGuardarCambioProveedor.Size = new System.Drawing.Size(176, 41);
			this.btnGuardarCambioProveedor.TabIndex = 3;
			this.btnGuardarCambioProveedor.Text = "GUARDAR";
			this.btnGuardarCambioProveedor.UseVisualStyleBackColor = false;
			this.btnGuardarCambioProveedor.Click += new System.EventHandler(this.btnGuardarCambioProveedor_Click);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(516, 61);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(152, 24);
			this.txtTel.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(20, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(648, 227);
			this.dataGridView1.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(479, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "TEL:";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(125, 64);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(152, 24);
			this.txtCorreo.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "CORREO:";
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(516, 24);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(152, 24);
			this.txtRazonSocial.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(397, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "RAZON SOCIAL:";
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(125, 31);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(152, 24);
			this.txtDocumento.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "DOCUMENTO:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(763, 9);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 14;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 515);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmProveedores";
			this.Text = "FrmProveedores";
			this.Load += new System.EventHandler(this.FrmProveedores_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnEditarProveedor;
		private System.Windows.Forms.Button btnGuardarCambioProveedor;
		private System.Windows.Forms.Button btnBorrarProveedor;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label btnCerrar;
	}
}