namespace SISTEM_SUPER
{
	partial class FrmCamarasSeguridad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCamarasSeguridad));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnCapturar = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnGrabar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(28, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(305, 262);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(363, 109);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(305, 262);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnCapturar
			// 
			this.btnCapturar.BackColor = System.Drawing.Color.DarkBlue;
			this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCapturar.FlatAppearance.BorderSize = 0;
			this.btnCapturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapturar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapturar.ForeColor = System.Drawing.Color.White;
			this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
			this.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapturar.Location = new System.Drawing.Point(492, 33);
			this.btnCapturar.Name = "btnCapturar";
			this.btnCapturar.Size = new System.Drawing.Size(176, 40);
			this.btnCapturar.TabIndex = 3;
			this.btnCapturar.Text = "CAPTURAR";
			this.btnCapturar.UseVisualStyleBackColor = false;
			this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(28, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(149, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// btnGrabar
			// 
			this.btnGrabar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGrabar.FlatAppearance.BorderSize = 0;
			this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGrabar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
			this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGrabar.Location = new System.Drawing.Point(193, 33);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(176, 40);
			this.btnGrabar.TabIndex = 5;
			this.btnGrabar.Text = "ACTIVAR";
			this.btnGrabar.UseVisualStyleBackColor = false;
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			// 
			// FrmCamarasSeguridad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 391);
			this.Controls.Add(this.btnGrabar);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnCapturar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmCamarasSeguridad";
			this.Text = "Camaras de Seguridad";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCamarasSeguridad_FormClosed);
			this.Load += new System.EventHandler(this.FrmCamarasSeguridad_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnCapturar;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnGrabar;
	}
}