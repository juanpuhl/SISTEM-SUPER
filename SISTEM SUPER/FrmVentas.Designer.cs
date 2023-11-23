namespace SISTEM_SUPER
{
	partial class FrmVentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
			this.txtTotalPagar = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.txtCantidad = new System.Windows.Forms.NumericUpDown();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtApellidoCliente = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtCondicionFiscal = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btnBuscarVenta = new System.Windows.Forms.Button();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.txtDocCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtPrecioProducto = new System.Windows.Forms.TextBox();
			this.txtNomProducto = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.txtCodProducto = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPagaCon = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTotalPagar
			// 
			this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPagar.Location = new System.Drawing.Point(675, 272);
			this.txtTotalPagar.Name = "txtTotalPagar";
			this.txtTotalPagar.Size = new System.Drawing.Size(106, 26);
			this.txtTotalPagar.TabIndex = 29;
			this.txtTotalPagar.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(673, 249);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(108, 20);
			this.label12.TabIndex = 30;
			this.label12.Text = "Total a Pagar:";
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.AllowDrop = true;
			this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProducto.Image = global::SISTEM_SUPER.Properties.Resources.iconplus;
			this.btnAgregarProducto.Location = new System.Drawing.Point(676, 168);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(80, 77);
			this.btnAgregarProducto.TabIndex = 37;
			this.btnAgregarProducto.Text = "Agregar";
			this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.AllowDrop = true;
			this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
			this.btnRegistrar.Location = new System.Drawing.Point(676, 429);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(105, 66);
			this.btnRegistrar.TabIndex = 38;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
			this.dataGridView1.Location = new System.Drawing.Point(26, 279);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(644, 218);
			this.dataGridView1.TabIndex = 36;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// Producto
			// 
			this.Producto.HeaderText = "Producto";
			this.Producto.Name = "Producto";
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "Precio";
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
			// btneliminar
			// 
			this.btneliminar.HeaderText = "";
			this.btneliminar.Name = "btneliminar";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(543, 68);
			this.txtCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(91, 22);
			this.txtCantidad.TabIndex = 10;
			this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.Location = new System.Drawing.Point(105, 42);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(29, 22);
			this.txtIdProducto.TabIndex = 9;
			this.txtIdProducto.Visible = false;
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarProducto.Location = new System.Drawing.Point(139, 52);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.Size = new System.Drawing.Size(43, 36);
			this.btnBuscarProducto.TabIndex = 6;
			this.btnBuscarProducto.UseVisualStyleBackColor = true;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(543, 51);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 17);
			this.label11.TabIndex = 8;
			this.label11.Text = "Cantidad:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtApellidoCliente);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.txtCondicionFiscal);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.btnBuscarVenta);
			this.groupBox2.Controls.Add(this.txtNombreCliente);
			this.groupBox2.Controls.Add(this.txtDocCliente);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(214, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(567, 111);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Cliente";
			// 
			// txtApellidoCliente
			// 
			this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoCliente.Location = new System.Drawing.Point(69, 88);
			this.txtApellidoCliente.Name = "txtApellidoCliente";
			this.txtApellidoCliente.Size = new System.Drawing.Size(221, 22);
			this.txtApellidoCliente.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(4, 88);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(61, 17);
			this.label16.TabIndex = 7;
			this.label16.Text = "Apellido:";
			// 
			// txtCondicionFiscal
			// 
			this.txtCondicionFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCondicionFiscal.Location = new System.Drawing.Point(395, 57);
			this.txtCondicionFiscal.Name = "txtCondicionFiscal";
			this.txtCondicionFiscal.Size = new System.Drawing.Size(162, 22);
			this.txtCondicionFiscal.TabIndex = 6;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(392, 37);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(108, 17);
			this.label15.TabIndex = 5;
			this.label15.Text = "Condicion Fiscal:";
			// 
			// btnBuscarVenta
			// 
			this.btnBuscarVenta.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarVenta.Location = new System.Drawing.Point(312, 33);
			this.btnBuscarVenta.Name = "btnBuscarVenta";
			this.btnBuscarVenta.Size = new System.Drawing.Size(67, 64);
			this.btnBuscarVenta.TabIndex = 4;
			this.btnBuscarVenta.UseVisualStyleBackColor = true;
			this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCliente.Location = new System.Drawing.Point(69, 57);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(221, 22);
			this.txtNombreCliente.TabIndex = 3;
			// 
			// txtDocCliente
			// 
			this.txtDocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocCliente.Location = new System.Drawing.Point(69, 18);
			this.txtDocCliente.Name = "txtDocCliente";
			this.txtDocCliente.Size = new System.Drawing.Size(222, 22);
			this.txtDocCliente.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nombre:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "N° DNI:";
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Location = new System.Drawing.Point(724, 25);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.Size = new System.Drawing.Size(32, 20);
			this.txtIdCliente.TabIndex = 5;
			this.txtIdCliente.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 20);
			this.label1.TabIndex = 28;
			this.label1.Text = "Registrar Venta:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTipoDoc);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(26, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 111);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Venta";
			// 
			// cmbTipoDoc
			// 
			this.cmbTipoDoc.BackColor = System.Drawing.Color.LightGray;
			this.cmbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoDoc.FormattingEnabled = true;
			this.cmbTipoDoc.Location = new System.Drawing.Point(9, 81);
			this.cmbTipoDoc.Name = "cmbTipoDoc";
			this.cmbTipoDoc.Size = new System.Drawing.Size(128, 24);
			this.cmbTipoDoc.TabIndex = 3;
			// 
			// txtFecha
			// 
			this.txtFecha.BackColor = System.Drawing.Color.LightGray;
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(9, 34);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(128, 22);
			this.txtFecha.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tipo Documento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Fecha:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(434, 51);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 17);
			this.label9.TabIndex = 7;
			this.label9.Text = "Stock:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(328, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Precio:";
			// 
			// txtStock
			// 
			this.txtStock.BackColor = System.Drawing.Color.LightGray;
			this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStock.Location = new System.Drawing.Point(437, 68);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(100, 22);
			this.txtStock.TabIndex = 5;
			// 
			// txtPrecioProducto
			// 
			this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioProducto.Location = new System.Drawing.Point(331, 68);
			this.txtPrecioProducto.Name = "txtPrecioProducto";
			this.txtPrecioProducto.Size = new System.Drawing.Size(100, 22);
			this.txtPrecioProducto.TabIndex = 4;
			this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
			// 
			// txtNomProducto
			// 
			this.txtNomProducto.BackColor = System.Drawing.Color.LightGray;
			this.txtNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomProducto.Location = new System.Drawing.Point(188, 68);
			this.txtNomProducto.Name = "txtNomProducto";
			this.txtNomProducto.Size = new System.Drawing.Size(137, 22);
			this.txtNomProducto.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(185, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Producto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Cod. Producto:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(960, -5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 31;
			this.btnCerrar.Text = "X";
			// 
			// txtCodProducto
			// 
			this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodProducto.Location = new System.Drawing.Point(9, 68);
			this.txtCodProducto.Name = "txtCodProducto";
			this.txtCodProducto.Size = new System.Drawing.Size(125, 22);
			this.txtCodProducto.TabIndex = 0;
			this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtCantidad);
			this.groupBox3.Controls.Add(this.txtIdProducto);
			this.groupBox3.Controls.Add(this.btnBuscarProducto);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtStock);
			this.groupBox3.Controls.Add(this.txtPrecioProducto);
			this.groupBox3.Controls.Add(this.txtNomProducto);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txtCodProducto);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(26, 170);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(644, 103);
			this.groupBox3.TabIndex = 35;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Informacion de Producto";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(778, 529);
			this.label10.TabIndex = 39;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPagaCon
			// 
			this.txtPagaCon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPagaCon.Location = new System.Drawing.Point(674, 324);
			this.txtPagaCon.Name = "txtPagaCon";
			this.txtPagaCon.Size = new System.Drawing.Size(107, 22);
			this.txtPagaCon.TabIndex = 40;
			this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
			this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(672, 307);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 17);
			this.label13.TabIndex = 41;
			this.label13.Text = "Paga con:";
			// 
			// txtCambio
			// 
			this.txtCambio.BackColor = System.Drawing.Color.LightGray;
			this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCambio.Location = new System.Drawing.Point(675, 378);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(106, 22);
			this.txtCambio.TabIndex = 42;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(673, 361);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(58, 17);
			this.label14.TabIndex = 43;
			this.label14.Text = "Cambio:";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(770, 6);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(19, 18);
			this.label17.TabIndex = 44;
			this.label17.Text = "X";
			this.label17.Click += new System.EventHandler(this.label17_Click);
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 544);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtIdCliente);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtPagaCon);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtTotalPagar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnAgregarProducto);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label10);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVentas";
			this.Text = "FrmVentas";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTotalPagar;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.NumericUpDown txtCantidad;
		private System.Windows.Forms.TextBox txtIdProducto;
		private System.Windows.Forms.Button btnBuscarProducto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.Button btnBuscarVenta;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.TextBox txtDocCliente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbTipoDoc;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtPrecioProducto;
		private System.Windows.Forms.TextBox txtNomProducto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.TextBox txtCodProducto;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
		private System.Windows.Forms.TextBox txtPagaCon;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtApellidoCliente;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtCondicionFiscal;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
	}
}