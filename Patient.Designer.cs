
namespace Hospital_Management_System
{
	partial class Patient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PatientGridView = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.PatAgeBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PatPhoneBox = new System.Windows.Forms.TextBox();
			this.PatAddressBox = new System.Windows.Forms.TextBox();
			this.PatNameBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.PatGenderComBox = new System.Windows.Forms.ComboBox();
			this.PatBloodCombBox = new System.Windows.Forms.ComboBox();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.SeachtextBox = new System.Windows.Forms.TextBox();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.DocRecomboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(356, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "PATIENT ";
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
			// PatientGridView
			// 
			this.PatientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PatientGridView.BackgroundColor = System.Drawing.Color.SeaShell;
			this.PatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PatientGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.PatientGridView.Location = new System.Drawing.Point(288, 129);
			this.PatientGridView.MultiSelect = false;
			this.PatientGridView.Name = "PatientGridView";
			this.PatientGridView.ReadOnly = true;
			this.PatientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PatientGridView.Size = new System.Drawing.Size(551, 358);
			this.PatientGridView.TabIndex = 45;
			this.PatientGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientGridView_CellMouseDoubleClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(284, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 20);
			this.label7.TabIndex = 44;
			this.label7.Text = "Patient List";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateBtn.Location = new System.Drawing.Point(128, 470);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(64, 39);
			this.UpdateBtn.TabIndex = 43;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeleteBtn.Location = new System.Drawing.Point(198, 470);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(64, 39);
			this.DeleteBtn.TabIndex = 42;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = false;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Purple;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(11, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 39);
			this.button2.TabIndex = 41;
			this.button2.Text = "Go Home";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddBtn.Location = new System.Drawing.Point(58, 470);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(64, 39);
			this.AddBtn.TabIndex = 40;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(58, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 39;
			this.label6.Text = "Age";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// PatAgeBox
			// 
			this.PatAgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatAgeBox.Location = new System.Drawing.Point(98, 295);
			this.PatAgeBox.Name = "PatAgeBox";
			this.PatAgeBox.Size = new System.Drawing.Size(166, 26);
			this.PatAgeBox.TabIndex = 38;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(35, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 35;
			this.label2.Text = "Patient Name";
			// 
			// PatPhoneBox
			// 
			this.PatPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatPhoneBox.Location = new System.Drawing.Point(98, 249);
			this.PatPhoneBox.Name = "PatPhoneBox";
			this.PatPhoneBox.Size = new System.Drawing.Size(166, 26);
			this.PatPhoneBox.TabIndex = 34;
			// 
			// PatAddressBox
			// 
			this.PatAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatAddressBox.Location = new System.Drawing.Point(98, 206);
			this.PatAddressBox.Name = "PatAddressBox";
			this.PatAddressBox.Size = new System.Drawing.Size(166, 26);
			this.PatAddressBox.TabIndex = 33;
			// 
			// PatNameBox
			// 
			this.PatNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatNameBox.Location = new System.Drawing.Point(98, 163);
			this.PatNameBox.Name = "PatNameBox";
			this.PatNameBox.Size = new System.Drawing.Size(166, 26);
			this.PatNameBox.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(44, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 36;
			this.label4.Text = "Phone";
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
			this.panel1.Size = new System.Drawing.Size(851, 74);
			this.panel1.TabIndex = 31;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(6, 340);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 48;
			this.label8.Text = "Recomended";
			// 
			// PatGenderComBox
			// 
			this.PatGenderComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatGenderComBox.FormattingEnabled = true;
			this.PatGenderComBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.PatGenderComBox.Location = new System.Drawing.Point(96, 378);
			this.PatGenderComBox.Name = "PatGenderComBox";
			this.PatGenderComBox.Size = new System.Drawing.Size(166, 28);
			this.PatGenderComBox.TabIndex = 49;
			this.PatGenderComBox.Text = "Gender";
			// 
			// PatBloodCombBox
			// 
			this.PatBloodCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatBloodCombBox.FormattingEnabled = true;
			this.PatBloodCombBox.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "O-",
            "AB-",
            "AB+"});
			this.PatBloodCombBox.Location = new System.Drawing.Point(96, 421);
			this.PatBloodCombBox.Name = "PatBloodCombBox";
			this.PatBloodCombBox.Size = new System.Drawing.Size(166, 28);
			this.PatBloodCombBox.TabIndex = 50;
			this.PatBloodCombBox.Text = "Blood Group";
			// 
			// ClearBtn
			// 
			this.ClearBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClearBtn.Location = new System.Drawing.Point(128, 525);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(64, 39);
			this.ClearBtn.TabIndex = 51;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = false;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// SeachtextBox
			// 
			this.SeachtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SeachtextBox.Location = new System.Drawing.Point(620, 100);
			this.SeachtextBox.Name = "SeachtextBox";
			this.SeachtextBox.Size = new System.Drawing.Size(149, 26);
			this.SeachtextBox.TabIndex = 52;
			// 
			// SearchBtn
			// 
			this.SearchBtn.BackColor = System.Drawing.Color.Purple;
			this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SearchBtn.Location = new System.Drawing.Point(775, 100);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(64, 28);
			this.SearchBtn.TabIndex = 53;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = false;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
			this.DocRecomboBox.Location = new System.Drawing.Point(96, 332);
			this.DocRecomboBox.Name = "DocRecomboBox";
			this.DocRecomboBox.Size = new System.Drawing.Size(166, 28);
			this.DocRecomboBox.TabIndex = 54;
			this.DocRecomboBox.Text = "Select type";
			// 
			// Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(851, 583);
			this.Controls.Add(this.DocRecomboBox);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.SeachtextBox);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.PatBloodCombBox);
			this.Controls.Add(this.PatGenderComBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.PatientGridView);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.PatAgeBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PatPhoneBox);
			this.Controls.Add(this.PatAddressBox);
			this.Controls.Add(this.PatNameBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Patient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Patient";
			this.Load += new System.EventHandler(this.Patient_Load);
			((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView PatientGridView;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox PatAgeBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PatPhoneBox;
		private System.Windows.Forms.TextBox PatAddressBox;
		private System.Windows.Forms.TextBox PatNameBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox PatGenderComBox;
		private System.Windows.Forms.ComboBox PatBloodCombBox;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.TextBox SeachtextBox;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.ComboBox DocRecomboBox;
	}
}