
namespace Hospital_Management_System
{
	partial class IT_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LogNameBox = new System.Windows.Forms.TextBox();
			this.LogPassBox = new System.Windows.Forms.TextBox();
			this.LogBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel1.Size = new System.Drawing.Size(423, 60);
			this.panel1.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(169, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "IT Login";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(149, 79);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(143, 138);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// LogNameBox
			// 
			this.LogNameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogNameBox.Location = new System.Drawing.Point(149, 240);
			this.LogNameBox.Name = "LogNameBox";
			this.LogNameBox.Size = new System.Drawing.Size(162, 26);
			this.LogNameBox.TabIndex = 21;
			// 
			// LogPassBox
			// 
			this.LogPassBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogPassBox.Location = new System.Drawing.Point(149, 275);
			this.LogPassBox.Name = "LogPassBox";
			this.LogPassBox.Size = new System.Drawing.Size(162, 26);
			this.LogPassBox.TabIndex = 20;
			this.LogPassBox.UseSystemPasswordChar = true;
			// 
			// LogBtn
			// 
			this.LogBtn.BackColor = System.Drawing.Color.Purple;
			this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LogBtn.Location = new System.Drawing.Point(188, 315);
			this.LogBtn.Name = "LogBtn";
			this.LogBtn.Size = new System.Drawing.Size(85, 39);
			this.LogBtn.TabIndex = 19;
			this.LogBtn.Text = "LOGIN";
			this.LogBtn.UseVisualStyleBackColor = false;
			this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(63, 281);
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
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(53, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "User Name";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(380, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 30;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// IT_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(423, 366);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.LogNameBox);
			this.Controls.Add(this.LogPassBox);
			this.Controls.Add(this.LogBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IT_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IT_Login";
			this.Load += new System.EventHandler(this.IT_Login_Load);
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
		private System.Windows.Forms.TextBox LogNameBox;
		private System.Windows.Forms.Button LogBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LogPassBox;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}