namespace SISTEM_SUPER.Modal
{
	partial class mdProductos
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
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = global::SISTEM_SUPER.Properties.Resources.clean_icon_215881;
			this.btnLimpiar.Location = new System.Drawing.Point(434, 29);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(52, 42);
			this.btnLimpiar.TabIndex = 36;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(376, 30);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(52, 42);
			this.btnBuscar.TabIndex = 37;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(234, 50);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(136, 22);
			this.txtBusqueda.TabIndex = 35;
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.Location = new System.Drawing.Point(98, 47);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(130, 24);
			this.cboBusqueda.TabIndex = 34;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(17, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(75, 16);
			this.label12.TabIndex = 33;
			this.label12.Text = "Buscar por:";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(478, 79);
			this.label10.TabIndex = 32;
			this.label10.Text = "Lista de Productos:";
			// 
			// dgvdata
			// 
			this.dgvdata.AllowUserToAddRows = false;
			this.dgvdata.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo_Producto,
            this.Nombre,
            this.Descripcion,
            this.Marca,
            this.Precio_Compra,
            this.Precio_Venta,
            this.Stock});
			this.dgvdata.GridColor = System.Drawing.Color.WhiteSmoke;
			this.dgvdata.Location = new System.Drawing.Point(10, 101);
			this.dgvdata.MultiSelect = false;
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.ReadOnly = true;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvdata.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvdata.RowTemplate.Height = 28;
			this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvdata.Size = new System.Drawing.Size(480, 209);
			this.dgvdata.TabIndex = 31;
			this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Codigo_Producto
			// 
			this.Codigo_Producto.HeaderText = "Codigo_Producto";
			this.Codigo_Producto.Name = "Codigo_Producto";
			this.Codigo_Producto.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Visible = false;
			// 
			// Marca
			// 
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			// 
			// Precio_Compra
			// 
			this.Precio_Compra.HeaderText = "Precio_Compra";
			this.Precio_Compra.Name = "Precio_Compra";
			this.Precio_Compra.ReadOnly = true;
			this.Precio_Compra.Visible = false;
			// 
			// Precio_Venta
			// 
			this.Precio_Venta.HeaderText = "Precio_Venta";
			this.Precio_Venta.Name = "Precio_Venta";
			this.Precio_Venta.ReadOnly = true;
			this.Precio_Venta.Visible = false;
			// 
			// Stock
			// 
			this.Stock.HeaderText = "Stock";
			this.Stock.Name = "Stock";
			this.Stock.ReadOnly = true;
			this.Stock.Visible = false;
			// 
			// mdProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 327);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dgvdata);
			this.Name = "mdProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mdProductos";
			this.Load += new System.EventHandler(this.mdProductos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
	}
}