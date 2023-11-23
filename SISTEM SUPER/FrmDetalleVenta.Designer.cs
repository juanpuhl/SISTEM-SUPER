namespace SISTEM_SUPER
{
	partial class FrmDetalleVenta
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
			this.btnDescargarPDf = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMontoTotal = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDniCliente = new System.Windows.Forms.TextBox();
			this.txtTipoDoc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtApellidoCliente = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMontoPago = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMontoCambio = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDescargarPDf
			// 
			this.btnDescargarPDf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDescargarPDf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDescargarPDf.Image = global::SISTEM_SUPER.Properties.Resources.adobe_pdf_document_14979;
			this.btnDescargarPDf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDescargarPDf.Location = new System.Drawing.Point(485, 442);
			this.btnDescargarPDf.Name = "btnDescargarPDf";
			this.btnDescargarPDf.Size = new System.Drawing.Size(203, 40);
			this.btnDescargarPDf.TabIndex = 64;
			this.btnDescargarPDf.Text = "Descargar PDF";
			this.btnDescargarPDf.UseVisualStyleBackColor = true;
			this.btnDescargarPDf.Click += new System.EventHandler(this.btnDescargarPDf_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(113, 403);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 17);
			this.label6.TabIndex = 60;
			this.label6.Text = "Monto Total:";
			// 
			// txtMontoTotal
			// 
			this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMontoTotal.Location = new System.Drawing.Point(214, 401);
			this.txtMontoTotal.Name = "txtMontoTotal";
			this.txtMontoTotal.Size = new System.Drawing.Size(150, 22);
			this.txtMontoTotal.TabIndex = 62;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(578, 32);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(52, 36);
			this.btnBuscar.TabIndex = 58;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
			this.dataGridView1.Location = new System.Drawing.Point(111, 254);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(577, 141);
			this.dataGridView1.TabIndex = 63;
			// 
			// Productos
			// 
			this.Productos.HeaderText = "Productos";
			this.Productos.Name = "Productos";
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "PrecioVenta";
			this.PrecioVenta.Name = "PrecioVenta";
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
			// btnLimpiar
			// 
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = global::SISTEM_SUPER.Properties.Resources.clean_icon_215881;
			this.btnLimpiar.Location = new System.Drawing.Point(636, 32);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(52, 36);
			this.btnLimpiar.TabIndex = 57;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// txtNumeroDocumento
			// 
			this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroDocumento.Location = new System.Drawing.Point(515, 12);
			this.txtNumeroDocumento.Name = "txtNumeroDocumento";
			this.txtNumeroDocumento.Size = new System.Drawing.Size(56, 22);
			this.txtNumeroDocumento.TabIndex = 47;
			// 
			// txtFecha
			// 
			this.txtFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(9, 38);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 20);
			this.txtFecha.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(122, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 44;
			this.label3.Text = "Tipo Documento:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 17);
			this.label7.TabIndex = 43;
			this.label7.Text = "Dni Cliente:";
			// 
			// txtDniCliente
			// 
			this.txtDniCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDniCliente.Location = new System.Drawing.Point(9, 32);
			this.txtDniCliente.Name = "txtDniCliente";
			this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
			this.txtDniCliente.TabIndex = 45;
			// 
			// txtTipoDoc
			// 
			this.txtTipoDoc.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoDoc.Location = new System.Drawing.Point(115, 38);
			this.txtTipoDoc.Name = "txtTipoDoc";
			this.txtTipoDoc.Size = new System.Drawing.Size(161, 20);
			this.txtTipoDoc.TabIndex = 49;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(329, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 48;
			this.label5.Text = "Usuario:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(332, 37);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(223, 20);
			this.txtUsuario.TabIndex = 47;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 43;
			this.label4.Text = "Fecha:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtApellidoCliente);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtNombreCliente);
			this.groupBox2.Controls.Add(this.txtNumeroDocumento);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtDniCliente);
			this.groupBox2.Location = new System.Drawing.Point(111, 157);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(577, 78);
			this.groupBox2.TabIndex = 61;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Cliente";
			// 
			// txtApellidoCliente
			// 
			this.txtApellidoCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoCliente.Location = new System.Drawing.Point(271, 32);
			this.txtApellidoCliente.Name = "txtApellidoCliente";
			this.txtApellidoCliente.Size = new System.Drawing.Size(150, 20);
			this.txtApellidoCliente.TabIndex = 53;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(268, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(107, 17);
			this.label10.TabIndex = 52;
			this.label10.Text = "Apellido Cliente:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(112, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(105, 17);
			this.label9.TabIndex = 50;
			this.label9.Text = "Nombre Cliente:";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCliente.Location = new System.Drawing.Point(115, 32);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(150, 20);
			this.txtNombreCliente.TabIndex = 51;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTipoDoc);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(111, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(577, 72);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Compra";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(427, 50);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(136, 22);
			this.txtBusqueda.TabIndex = 56;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(424, 32);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(130, 16);
			this.label12.TabIndex = 55;
			this.label12.Text = "Número Documento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(108, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 18);
			this.label2.TabIndex = 54;
			this.label2.Text = "DETALLE VENTA:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(98, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(605, 481);
			this.label1.TabIndex = 53;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(113, 434);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 17);
			this.label11.TabIndex = 65;
			this.label11.Text = "Monto Pago:";
			// 
			// txtMontoPago
			// 
			this.txtMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMontoPago.Location = new System.Drawing.Point(214, 432);
			this.txtMontoPago.Name = "txtMontoPago";
			this.txtMontoPago.Size = new System.Drawing.Size(150, 22);
			this.txtMontoPago.TabIndex = 66;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(113, 462);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 17);
			this.label13.TabIndex = 67;
			this.label13.Text = "Monto Cambio:";
			// 
			// txtMontoCambio
			// 
			this.txtMontoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMontoCambio.Location = new System.Drawing.Point(214, 460);
			this.txtMontoCambio.Name = "txtMontoCambio";
			this.txtMontoCambio.Size = new System.Drawing.Size(150, 22);
			this.txtMontoCambio.TabIndex = 68;
			// 
			// FrmDetalleVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 517);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtMontoCambio);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtMontoPago);
			this.Controls.Add(this.btnDescargarPDf);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMontoTotal);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmDetalleVenta";
			this.Text = "FrmDetalleVenta";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDescargarPDf;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMontoTotal;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox txtNumeroDocumento;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDniCliente;
		private System.Windows.Forms.TextBox txtTipoDoc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtApellidoCliente;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtMontoPago;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMontoCambio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
	}
}