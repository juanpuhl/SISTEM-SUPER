namespace SISTEM_SUPER
{
	partial class FrmDetalleCompra
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTipoDoc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNombreProv = new System.Windows.Forms.TextBox();
			this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDocProveedor = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMontoTotal = new System.Windows.Forms.TextBox();
			this.btnDescargarPDf = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(111, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(605, 436);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(121, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "DETALLE COMPRA";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(440, 61);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(136, 22);
			this.txtBusqueda.TabIndex = 39;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(437, 43);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(130, 16);
			this.label12.TabIndex = 38;
			this.label12.Text = "Número Documento:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTipoDoc);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(124, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(577, 87);
			this.groupBox1.TabIndex = 42;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Compra";
			// 
			// txtTipoDoc
			// 
			this.txtTipoDoc.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoDoc.Location = new System.Drawing.Point(115, 50);
			this.txtTipoDoc.Name = "txtTipoDoc";
			this.txtTipoDoc.Size = new System.Drawing.Size(161, 20);
			this.txtTipoDoc.TabIndex = 49;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(329, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 48;
			this.label5.Text = "Usuario:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(332, 49);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(223, 20);
			this.txtUsuario.TabIndex = 47;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 43;
			this.label4.Text = "Fecha:";
			// 
			// txtFecha
			// 
			this.txtFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(9, 50);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 20);
			this.txtFecha.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(122, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 44;
			this.label3.Text = "Tipo Documento:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNombreProv);
			this.groupBox2.Controls.Add(this.txtNumeroDocumento);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtDocProveedor);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(124, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(577, 87);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Proveedor";
			// 
			// txtNombreProv
			// 
			this.txtNombreProv.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtNombreProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreProv.Location = new System.Drawing.Point(165, 50);
			this.txtNombreProv.Name = "txtNombreProv";
			this.txtNombreProv.Size = new System.Drawing.Size(161, 20);
			this.txtNombreProv.TabIndex = 49;
			// 
			// txtNumeroDocumento
			// 
			this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroDocumento.Location = new System.Drawing.Point(499, 49);
			this.txtNumeroDocumento.Name = "txtNumeroDocumento";
			this.txtNumeroDocumento.Size = new System.Drawing.Size(56, 22);
			this.txtNumeroDocumento.TabIndex = 47;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 17);
			this.label7.TabIndex = 43;
			this.label7.Text = "Número Documento:";
			// 
			// txtDocProveedor
			// 
			this.txtDocProveedor.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtDocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocProveedor.Location = new System.Drawing.Point(9, 50);
			this.txtDocProveedor.Name = "txtDocProveedor";
			this.txtDocProveedor.Size = new System.Drawing.Size(150, 20);
			this.txtDocProveedor.TabIndex = 45;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(167, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 17);
			this.label8.TabIndex = 44;
			this.label8.Text = "Razón Social:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
			this.dataGridView1.Location = new System.Drawing.Point(124, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(577, 159);
			this.dataGridView1.TabIndex = 51;
			// 
			// Productos
			// 
			this.Productos.HeaderText = "Productos";
			this.Productos.Name = "Productos";
			// 
			// PrecioCompra
			// 
			this.PrecioCompra.HeaderText = "PrecioCompra";
			this.PrecioCompra.Name = "PrecioCompra";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "SubTotal";
			this.SubTotal.Name = "SubTotal";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(121, 452);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 17);
			this.label6.TabIndex = 50;
			this.label6.Text = "Monto Total:";
			// 
			// txtMontoTotal
			// 
			this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMontoTotal.Location = new System.Drawing.Point(209, 447);
			this.txtMontoTotal.Name = "txtMontoTotal";
			this.txtMontoTotal.Size = new System.Drawing.Size(150, 22);
			this.txtMontoTotal.TabIndex = 51;
			// 
			// btnDescargarPDf
			// 
			this.btnDescargarPDf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDescargarPDf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDescargarPDf.Image = global::SISTEM_SUPER.Properties.Resources.adobe_pdf_document_14979;
			this.btnDescargarPDf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDescargarPDf.Location = new System.Drawing.Point(495, 439);
			this.btnDescargarPDf.Name = "btnDescargarPDf";
			this.btnDescargarPDf.Size = new System.Drawing.Size(203, 40);
			this.btnDescargarPDf.TabIndex = 52;
			this.btnDescargarPDf.Text = "Descargar PDF";
			this.btnDescargarPDf.UseVisualStyleBackColor = true;
			this.btnDescargarPDf.Click += new System.EventHandler(this.btnDescargarPDf_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = global::SISTEM_SUPER.Properties.Resources.clean_icon_215881;
			this.btnLimpiar.Location = new System.Drawing.Point(649, 43);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(52, 36);
			this.btnLimpiar.TabIndex = 40;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(591, 43);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(52, 36);
			this.btnBuscar.TabIndex = 41;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// FrmDetalleCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 500);
			this.Controls.Add(this.btnDescargarPDf);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMontoTotal);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmDetalleCompra";
			this.Text = "FrmDetalleCompra";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTipoDoc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtNombreProv;
		private System.Windows.Forms.TextBox txtNumeroDocumento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDocProveedor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMontoTotal;
		private System.Windows.Forms.Button btnDescargarPDf;
		private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
	}
}