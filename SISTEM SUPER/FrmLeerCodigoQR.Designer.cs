namespace SISTEM_SUPER
{
	partial class FrmLeerCodigoQR
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rdbApagar = new System.Windows.Forms.RadioButton();
			this.rdbEncender = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(39, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 246);
			this.panel1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.textBox1.BackColor = System.Drawing.Color.LightGray;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(437, 42);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(283, 198);
			this.textBox1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(321, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "CAMARA";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(492, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "CONTENIDO QR";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.rdbApagar);
			this.panel3.Controls.Add(this.rdbEncender);
			this.panel3.Location = new System.Drawing.Point(288, 42);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(134, 198);
			this.panel3.TabIndex = 1;
			// 
			// rdbApagar
			// 
			this.rdbApagar.AutoSize = true;
			this.rdbApagar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdbApagar.Location = new System.Drawing.Point(16, 82);
			this.rdbApagar.Name = "rdbApagar";
			this.rdbApagar.Size = new System.Drawing.Size(65, 17);
			this.rdbApagar.TabIndex = 1;
			this.rdbApagar.TabStop = true;
			this.rdbApagar.Text = "Apagar";
			this.rdbApagar.UseVisualStyleBackColor = true;
			this.rdbApagar.CheckedChanged += new System.EventHandler(this.rdbApagar_CheckedChanged_1);
			// 
			// rdbEncender
			// 
			this.rdbEncender.AutoSize = true;
			this.rdbEncender.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdbEncender.Location = new System.Drawing.Point(16, 37);
			this.rdbEncender.Name = "rdbEncender";
			this.rdbEncender.Size = new System.Drawing.Size(79, 17);
			this.rdbEncender.TabIndex = 0;
			this.rdbEncender.TabStop = true;
			this.rdbEncender.Text = "Encender";
			this.rdbEncender.UseVisualStyleBackColor = true;
			this.rdbEncender.CheckedChanged += new System.EventHandler(this.rdbEncender_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(71, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "IMAGEN QR";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(3, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(211, 198);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(114, 19);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(161, 47);
			this.btnLimpiar.TabIndex = 2;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(374, 19);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(161, 47);
			this.btnIngresar.TabIndex = 1;
			this.btnIngresar.Text = "PROCESAR QR";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnLimpiar);
			this.panel2.Controls.Add(this.btnIngresar);
			this.panel2.Location = new System.Drawing.Point(36, 290);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(728, 96);
			this.panel2.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(39, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "LECTOR QR";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.AutoSize = true;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(741, 13);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(19, 18);
			this.btnCerrar.TabIndex = 21;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// FrmLeerCodigoQR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 399);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmLeerCodigoQR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Leer QR";
			this.Load += new System.EventHandler(this.FrmLeerCodigoQR_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rdbApagar;
		private System.Windows.Forms.RadioButton rdbEncender;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label btnCerrar;
	}
}