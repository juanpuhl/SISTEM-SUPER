namespace SISTEM_SUPER
{
	partial class FrmReporteCompra
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtfechafin = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmboProveedor = new System.Windows.Forms.ComboBox();
			this.btnBuscarProv = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscarPorColum = new System.Windows.Forms.Button();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtfechainicio
			// 
			this.txtfechainicio.CustomFormat = "dd/mm/yyyy";
			this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfechainicio.Location = new System.Drawing.Point(104, 46);
			this.txtfechainicio.Name = "txtfechainicio";
			this.txtfechainicio.Size = new System.Drawing.Size(101, 20);
			this.txtfechainicio.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(747, 81);
			this.label1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reporte de Compras:";
			// 
			// txtfechafin
			// 
			this.txtfechafin.CustomFormat = "dd/mm/yyyy";
			this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfechafin.Location = new System.Drawing.Point(297, 47);
			this.txtfechafin.Name = "txtfechafin";
			this.txtfechafin.Size = new System.Drawing.Size(101, 20);
			this.txtfechafin.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(23, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fecha Inicio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(230, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Fecha Fin:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(434, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Proveedor:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(15, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(744, 356);
			this.label6.TabIndex = 7;
			// 
			// cmboProveedor
			// 
			this.cmboProveedor.FormattingEnabled = true;
			this.cmboProveedor.Location = new System.Drawing.Point(507, 45);
			this.cmboProveedor.Name = "cmboProveedor";
			this.cmboProveedor.Size = new System.Drawing.Size(121, 21);
			this.cmboProveedor.TabIndex = 8;
			// 
			// btnBuscarProv
			// 
			this.btnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarProv.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarProv.Location = new System.Drawing.Point(654, 30);
			this.btnBuscarProv.Name = "btnBuscarProv";
			this.btnBuscarProv.Size = new System.Drawing.Size(52, 36);
			this.btnBuscarProv.TabIndex = 59;
			this.btnBuscarProv.UseVisualStyleBackColor = true;
			this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
			this.dataGridView1.Location = new System.Drawing.Point(25, 168);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Size = new System.Drawing.Size(727, 262);
			this.dataGridView1.TabIndex = 60;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = global::SISTEM_SUPER.Properties.Resources.clean_icon_215881;
			this.btnLimpiar.Location = new System.Drawing.Point(439, 112);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(52, 42);
			this.btnLimpiar.TabIndex = 64;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnBuscarPorColum
			// 
			this.btnBuscarPorColum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarPorColum.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarPorColum.Location = new System.Drawing.Point(381, 113);
			this.btnBuscarPorColum.Name = "btnBuscarPorColum";
			this.btnBuscarPorColum.Size = new System.Drawing.Size(52, 42);
			this.btnBuscarPorColum.TabIndex = 65;
			this.btnBuscarPorColum.UseVisualStyleBackColor = true;
			this.btnBuscarPorColum.Click += new System.EventHandler(this.btnBuscarPorColum_Click);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(239, 133);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(136, 22);
			this.txtBusqueda.TabIndex = 63;
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.Location = new System.Drawing.Point(103, 130);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(130, 24);
			this.cboBusqueda.TabIndex = 62;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(22, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(75, 16);
			this.label12.TabIndex = 61;
			this.label12.Text = "Buscar por:";
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "SubTotal";
			this.SubTotal.Name = "SubTotal";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "Precio Venta";
			this.PrecioVenta.Name = "PrecioVenta";
			// 
			// PrecioCompra
			// 
			this.PrecioCompra.HeaderText = "Precio Compra";
			this.PrecioCompra.Name = "PrecioCompra";
			// 
			// NombreProducto
			// 
			this.NombreProducto.HeaderText = "Nombre Producto";
			this.NombreProducto.Name = "NombreProducto";
			// 
			// CodigoProducto
			// 
			this.CodigoProducto.HeaderText = "Codigo Producto";
			this.CodigoProducto.Name = "CodigoProducto";
			// 
			// RazonSocial
			// 
			this.RazonSocial.HeaderText = "Razon Social";
			this.RazonSocial.Name = "RazonSocial";
			// 
			// DocumentoProveedor
			// 
			this.DocumentoProveedor.HeaderText = "Documento Proveedor";
			this.DocumentoProveedor.Name = "DocumentoProveedor";
			// 
			// UsuarioRegistro
			// 
			this.UsuarioRegistro.HeaderText = "Usuario Registro";
			this.UsuarioRegistro.Name = "UsuarioRegistro";
			// 
			// MontoTotal
			// 
			this.MontoTotal.HeaderText = "Monto Total";
			this.MontoTotal.Name = "MontoTotal";
			// 
			// NumeroDocumento
			// 
			this.NumeroDocumento.HeaderText = "Numero Documento";
			this.NumeroDocumento.Name = "NumeroDocumento";
			// 
			// TipoDocumento
			// 
			this.TipoDocumento.HeaderText = "Tipo Documento";
			this.TipoDocumento.Name = "TipoDocumento";
			// 
			// FechaRegistro
			// 
			this.FechaRegistro.HeaderText = "Fecha Registro";
			this.FechaRegistro.Name = "FechaRegistro";
			// 
			// FrmReporteCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 488);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscarPorColum);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnBuscarProv);
			this.Controls.Add(this.cmboProveedor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtfechafin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtfechainicio);
			this.Controls.Add(this.label1);
			this.Name = "FrmReporteCompra";
			this.Text = "FrmReporteCompra";
			this.Load += new System.EventHandler(this.FrmReporteCompra_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker txtfechainicio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker txtfechafin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmboProveedor;
		private System.Windows.Forms.Button btnBuscarProv;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscarPorColum;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
		private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
		private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
	}
}