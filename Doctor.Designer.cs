
namespace Hospital_Management_System
{
	partial class Doctor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
			this.label7 = new System.Windows.Forms.Label();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.Home = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DocExpBox = new System.Windows.Forms.TextBox();
			this.DocNameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DocDataGridView = new System.Windows.Forms.DataGridView();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.DocPassBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.SeachtextBox = new System.Windows.Forms.TextBox();
			this.DocRecomboBox = new System.Windows.Forms.ComboBox();
			this.ReportBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DocDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Purple;
			this.label7.Location = new System.Drawing.Point(299, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 20);
			this.label7.TabIndex = 29;
			this.label7.Text = "DOCTOR LIST";
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.BackColor = System.Drawing.Color.DimGray;
			this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateBtn.Location = new System.Drawing.Point(142, 360);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(64, 39);
			this.UpdateBtn.TabIndex = 27;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.BackColor = System.Drawing.Color.DimGray;
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeleteBtn.Location = new System.Drawing.Point(212, 360);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(64, 39);
			this.DeleteBtn.TabIndex = 26;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = false;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// Home
			// 
			this.Home.BackColor = System.Drawing.Color.Purple;
			this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Home.Location = new System.Drawing.Point(20, 86);
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(71, 39);
			this.Home.TabIndex = 25;
			this.Home.Text = "Go Home";
			this.Home.UseVisualStyleBackColor = false;
			this.Home.Click += new System.EventHandler(this.Home_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.DimGray;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddBtn.Location = new System.Drawing.Point(72, 360);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(64, 39);
			this.AddBtn.TabIndex = 24;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(4, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Doctor Category";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(17, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "DoctorName";
			// 
			// DocExpBox
			// 
			this.DocExpBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocExpBox.Location = new System.Drawing.Point(109, 212);
			this.DocExpBox.Name = "DocExpBox";
			this.DocExpBox.Size = new System.Drawing.Size(166, 26);
			this.DocExpBox.TabIndex = 18;
			// 
			// DocNameBox
			// 
			this.DocNameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocNameBox.Location = new System.Drawing.Point(109, 169);
			this.DocNameBox.Name = "DocNameBox";
			this.DocNameBox.Size = new System.Drawing.Size(166, 26);
			this.DocNameBox.TabIndex = 17;
			this.DocNameBox.TextChanged += new System.EventHandler(this.DocName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(356, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "DOCTOR PANAL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(16, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(290, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "HOSPITAL MANAGMENT SYSTEM";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(4, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Doctor Expense";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Purple;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(860, 80);
			this.panel1.TabIndex = 15;
			// 
			// DocDataGridView
			// 
			this.DocDataGridView.AllowUserToOrderColumns = true;
			this.DocDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DocDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DocDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
			this.DocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DocDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DocDataGridView.Location = new System.Drawing.Point(291, 155);
			this.DocDataGridView.Name = "DocDataGridView";
			this.DocDataGridView.ReadOnly = true;
			this.DocDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DocDataGridView.Size = new System.Drawing.Size(545, 358);
			this.DocDataGridView.TabIndex = 30;
			this.DocDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DocDataGridView_CellMouseDoubleClick);
			// 
			// ClearBtn
			// 
			this.ClearBtn.BackColor = System.Drawing.Color.DimGray;
			this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClearBtn.Location = new System.Drawing.Point(142, 405);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(64, 39);
			this.ClearBtn.TabIndex = 31;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = false;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// DocPassBox
			// 
			this.DocPassBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocPassBox.Location = new System.Drawing.Point(109, 299);
			this.DocPassBox.Name = "DocPassBox";
			this.DocPassBox.Size = new System.Drawing.Size(166, 26);
			this.DocPassBox.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(26, 307);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 33;
			this.label8.Text = " Password";
			// 
			// SearchBtn
			// 
			this.SearchBtn.BackColor = System.Drawing.Color.Purple;
			this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SearchBtn.Location = new System.Drawing.Point(760, 126);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(76, 27);
			this.SearchBtn.TabIndex = 34;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = false;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// SeachtextBox
			// 
			this.SeachtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SeachtextBox.Location = new System.Drawing.Point(586, 126);
			this.SeachtextBox.Name = "SeachtextBox";
			this.SeachtextBox.Size = new System.Drawing.Size(168, 26);
			this.SeachtextBox.TabIndex = 35;
			// 
			// DocRecomboBox
			// 
			this.DocRecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DocRecomboBox.FormattingEnabled = true;
			this.DocRecomboBox.Items.AddRange(new object[] {
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
            "Neurologist"});
			this.DocRecomboBox.Location = new System.Drawing.Point(109, 258);
			this.DocRecomboBox.Name = "DocRecomboBox";
			this.DocRecomboBox.Size = new System.Drawing.Size(166, 28);
			this.DocRecomboBox.TabIndex = 55;
			this.DocRecomboBox.Text = "Select type";
			// 
			// ReportBtn
			// 
			this.ReportBtn.BackColor = System.Drawing.Color.Purple;
			this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ReportBtn.Location = new System.Drawing.Point(135, 86);
			this.ReportBtn.Name = "ReportBtn";
			this.ReportBtn.Size = new System.Drawing.Size(71, 39);
			this.ReportBtn.TabIndex = 56;
			this.ReportBtn.Text = "Report";
			this.ReportBtn.UseVisualStyleBackColor = false;
			this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
			// 
			// Doctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(860, 576);
			this.Controls.Add(this.ReportBtn);
			this.Controls.Add(this.DocRecomboBox);
			this.Controls.Add(this.SeachtextBox);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DocPassBox);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.DocDataGridView);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.Home);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.DocExpBox);
			this.Controls.Add(this.DocNameBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Doctor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doctor";
			this.Load += new System.EventHandler(this.Doctor_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DocDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button Home;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox DocExpBox;
		private System.Windows.Forms.TextBox DocNameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView DocDataGridView;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.TextBox DocPassBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.TextBox SeachtextBox;
		private System.Windows.Forms.ComboBox DocRecomboBox;
		private System.Windows.Forms.Button ReportBtn;
	}
}