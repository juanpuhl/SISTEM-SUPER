namespace SISTEM_SUPER
{
	partial class FrmImprimirPrecios
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
			this.btnGenerar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.picCodigoBarras = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerar.FlatAppearance.BorderSize = 0;
			this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnGenerar.Image = global::SISTEM_SUPER.Properties.Resources.save_file;
			this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGenerar.Location = new System.Drawing.Point(413, 65);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(180, 40);
			this.btnGenerar.TabIndex = 15;
			this.btnGenerar.Text = "GENERAR";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(775, 6);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 23;
			this.btnCerrar.Text = "X";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(202, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(258, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "GENERAR CODIGO BARRAS";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.picCodigoBarras);
			this.groupBox1.Controls.Add(this.btnGenerar);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(610, 179);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Codigo de Barra";
			// 
			// picCodigoBarras
			// 
			this.picCodigoBarras.Location = new System.Drawing.Point(6, 19);
			this.picCodigoBarras.Name = "picCodigoBarras";
			this.picCodigoBarras.Size = new System.Drawing.Size(385, 154);
			this.picCodigoBarras.TabIndex = 25;
			this.picCodigoBarras.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 267);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(610, 209);
			this.dataGridView1.TabIndex = 21;
			// 
			// FrmImprimirPrecios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 488);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmImprimirPrecios";
			this.Text = "Codgio Barra Precios";
			this.Load += new System.EventHandler(this.FrmImprimirPrecios_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox picCodigoBarras;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}