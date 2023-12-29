
namespace Hospital_Management_System
{
	partial class Doctor_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.DoclogNameBox = new System.Windows.Forms.TextBox();
			this.DocLogPassBox = new System.Windows.Forms.TextBox();
			this.DoclogBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DocCatacomboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Purple;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(475, 60);
			this.panel1.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(157, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Doctor Login";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 116);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(152, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// DoclogNameBox
			// 
			this.DoclogNameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoclogNameBox.Location = new System.Drawing.Point(264, 116);
			this.DoclogNameBox.Name = "DoclogNameBox";
			this.DoclogNameBox.Size = new System.Drawing.Size(169, 26);
			this.DoclogNameBox.TabIndex = 21;
			// 
			// DocLogPassBox
			// 
			this.DocLogPassBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocLogPassBox.Location = new System.Drawing.Point(264, 199);
			this.DocLogPassBox.Name = "DocLogPassBox";
			this.DocLogPassBox.Size = new System.Drawing.Size(169, 26);
			this.DocLogPassBox.TabIndex = 20;
			this.DocLogPassBox.UseSystemPasswordChar = true;
			// 
			// DoclogBtn
			// 
			this.DoclogBtn.BackColor = System.Drawing.Color.Purple;
			this.DoclogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DoclogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoclogBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DoclogBtn.Location = new System.Drawing.Point(288, 256);
			this.DoclogBtn.Name = "DoclogBtn";
			this.DoclogBtn.Size = new System.Drawing.Size(128, 39);
			this.DoclogBtn.TabIndex = 19;
			this.DoclogBtn.Text = "LOGIN";
			this.DoclogBtn.UseVisualStyleBackColor = false;
			this.DoclogBtn.Click += new System.EventHandler(this.DoclogBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(189, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 15);
			this.label2.TabIndex = 18;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(167, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "Doctor Name";
			// 
			// DocCatacomboBox
			// 
			this.DocCatacomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocCatacomboBox.FormattingEnabled = true;
			this.DocCatacomboBox.Items.AddRange(new object[] {
            "Emergency Medicine Physician ",
            "Pathologist",
            "Anesthesiologist",
            "Surgeons",
            "Cardiologist",
            "Dermatologis",
            "Gynecologist",
            "Pediatrician",
            "Psychiatrist",
            "Ophthalmologist",
            "Neurologists"});
			this.DocCatacomboBox.Location = new System.Drawing.Point(264, 156);
			this.DocCatacomboBox.Name = "DocCatacomboBox";
			this.DocCatacomboBox.Size = new System.Drawing.Size(169, 28);
			this.DocCatacomboBox.TabIndex = 25;
			this.DocCatacomboBox.Text = "Select";
			this.DocCatacomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Location = new System.Drawing.Point(189, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 26;
			this.label4.Text = "Category";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(432, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 30;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// Doctor_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(475, 368);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DocCatacomboBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.DoclogNameBox);
			this.Controls.Add(this.DocLogPassBox);
			this.Controls.Add(this.DoclogBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Doctor_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Doctor_Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox DoclogNameBox;
		private System.Windows.Forms.TextBox DocLogPassBox;
		private System.Windows.Forms.Button DoclogBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox DocCatacomboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}