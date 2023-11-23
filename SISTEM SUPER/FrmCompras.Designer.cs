namespace SISTEM_SUPER
{
    partial class FrmCompras
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
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtIdProveedor = new System.Windows.Forms.TextBox();
			this.btnBuscarProve = new System.Windows.Forms.Button();
			this.txtNombreProveedor = new System.Windows.Forms.TextBox();
			this.txtDocProveedor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtCantidad = new System.Windows.Forms.NumericUpDown();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.txtNomProducto = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodProducto = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTotalPagar = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(983, 9);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 13;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(52, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(778, 464);
			this.label10.TabIndex = 21;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTipoDoc);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(66, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(298, 81);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información Compra";
			// 
			// cmbTipoDoc
			// 
			this.cmbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoDoc.FormattingEnabled = true;
			this.cmbTipoDoc.Location = new System.Drawing.Point(115, 44);
			this.cmbTipoDoc.Name = "cmbTipoDoc";
			this.cmbTipoDoc.Size = new System.Drawing.Size(127, 24);
			this.cmbTipoDoc.TabIndex = 3;
			// 
			// txtFecha
			// 
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(9, 44);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 22);
			this.txtFecha.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(122, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tipo Documento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Fecha:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrar Compra:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtIdProveedor);
			this.groupBox2.Controls.Add(this.btnBuscarProve);
			this.groupBox2.Controls.Add(this.txtNombreProveedor);
			this.groupBox2.Controls.Add(this.txtDocProveedor);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(382, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(414, 81);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Información Proveedor";
			// 
			// txtIdProveedor
			// 
			this.txtIdProveedor.Location = new System.Drawing.Point(321, 9);
			this.txtIdProveedor.Name = "txtIdProveedor";
			this.txtIdProveedor.Size = new System.Drawing.Size(32, 22);
			this.txtIdProveedor.TabIndex = 5;
			this.txtIdProveedor.Visible = false;
			// 
			// btnBuscarProve
			// 
			this.btnBuscarProve.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarProve.Location = new System.Drawing.Point(119, 28);
			this.btnBuscarProve.Name = "btnBuscarProve";
			this.btnBuscarProve.Size = new System.Drawing.Size(43, 36);
			this.btnBuscarProve.TabIndex = 4;
			this.btnBuscarProve.UseVisualStyleBackColor = true;
			this.btnBuscarProve.Click += new System.EventHandler(this.btnBuscarProve_Click);
			// 
			// txtNombreProveedor
			// 
			this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreProveedor.Location = new System.Drawing.Point(168, 44);
			this.txtNombreProveedor.Name = "txtNombreProveedor";
			this.txtNombreProveedor.Size = new System.Drawing.Size(146, 22);
			this.txtNombreProveedor.TabIndex = 3;
			// 
			// txtDocProveedor
			// 
			this.txtDocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocProveedor.Location = new System.Drawing.Point(9, 44);
			this.txtDocProveedor.Name = "txtDocProveedor";
			this.txtDocProveedor.Size = new System.Drawing.Size(100, 22);
			this.txtDocProveedor.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(165, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Razón Social:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "N° DNI:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtCantidad);
			this.groupBox3.Controls.Add(this.txtIdProducto);
			this.groupBox3.Controls.Add(this.btnBuscarProducto);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtPrecioVenta);
			this.groupBox3.Controls.Add(this.txtPrecioCompra);
			this.groupBox3.Controls.Add(this.txtNomProducto);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txtCodProducto);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(66, 168);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(644, 84);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Informacion de Producto";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(543, 55);
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
			this.txtIdProducto.Location = new System.Drawing.Point(105, 29);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(29, 22);
			this.txtIdProducto.TabIndex = 9;
			this.txtIdProducto.Visible = false;
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Image = global::SISTEM_SUPER.Properties.Resources.buscar;
			this.btnBuscarProducto.Location = new System.Drawing.Point(139, 39);
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
			this.label11.Location = new System.Drawing.Point(543, 38);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 17);
			this.label11.TabIndex = 8;
			this.label11.Text = "Cantidad:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(434, 38);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 17);
			this.label9.TabIndex = 7;
			this.label9.Text = "Precio Venta:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(328, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Precio Compra:";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioVenta.Location = new System.Drawing.Point(437, 55);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(100, 22);
			this.txtPrecioVenta.TabIndex = 5;
			this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioCompra.Location = new System.Drawing.Point(331, 55);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(100, 22);
			this.txtPrecioCompra.TabIndex = 4;
			this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
			// 
			// txtNomProducto
			// 
			this.txtNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomProducto.Location = new System.Drawing.Point(188, 55);
			this.txtNomProducto.Name = "txtNomProducto";
			this.txtNomProducto.Size = new System.Drawing.Size(137, 22);
			this.txtNomProducto.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(185, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Producto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Cod. Producto:";
			// 
			// txtCodProducto
			// 
			this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodProducto.Location = new System.Drawing.Point(9, 55);
			this.txtCodProducto.Name = "txtCodProducto";
			this.txtCodProducto.Size = new System.Drawing.Size(125, 22);
			this.txtCodProducto.TabIndex = 0;
			this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
			this.dataGridView1.Location = new System.Drawing.Point(66, 258);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(644, 191);
			this.dataGridView1.TabIndex = 25;
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
			// PrecioCompra
			// 
			this.PrecioCompra.HeaderText = "Precio Compra";
			this.PrecioCompra.Name = "PrecioCompra";
			// 
			// PrecioVenta
			// 
			this.PrecioVenta.HeaderText = "Precio Venta";
			this.PrecioVenta.Name = "PrecioVenta";
			this.PrecioVenta.Visible = false;
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
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(714, 338);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(89, 17);
			this.label12.TabIndex = 4;
			this.label12.Text = "Total a Pagar:";
			// 
			// txtTotalPagar
			// 
			this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPagar.Location = new System.Drawing.Point(716, 355);
			this.txtTotalPagar.Name = "txtTotalPagar";
			this.txtTotalPagar.Size = new System.Drawing.Size(80, 22);
			this.txtTotalPagar.TabIndex = 4;
			this.txtTotalPagar.Text = "0";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.AllowDrop = true;
			this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Image = global::SISTEM_SUPER.Properties.Resources.okRegistro;
			this.btnRegistrar.Location = new System.Drawing.Point(716, 383);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(80, 66);
			this.btnRegistrar.TabIndex = 27;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.AllowDrop = true;
			this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProducto.Image = global::SISTEM_SUPER.Properties.Resources.iconplus;
			this.btnAgregarProducto.Location = new System.Drawing.Point(716, 175);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(80, 77);
			this.btnAgregarProducto.TabIndex = 26;
			this.btnAgregarProducto.Text = "Agregar";
			this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
			// 
			// FrmCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 550);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtTotalPagar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnAgregarProducto);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCompras";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.FrmCompras_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTipoDoc;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtIdProveedor;
		private System.Windows.Forms.Button btnBuscarProve;
		private System.Windows.Forms.TextBox txtNombreProveedor;
		private System.Windows.Forms.TextBox txtDocProveedor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnBuscarProducto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.TextBox txtNomProducto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCodProducto;
		private System.Windows.Forms.NumericUpDown txtCantidad;
		private System.Windows.Forms.TextBox txtIdProducto;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtTotalPagar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
	}
}