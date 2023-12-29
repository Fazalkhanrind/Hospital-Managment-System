using Hospital_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
	public partial class LogIn1 : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		public LogIn1()
		{
			InitializeComponent();
		}

		private void Log1Btn_Click(object sender, EventArgs e)
		{
			SignUP log = new SignUP();
			if (string.IsNullOrEmpty(Log1NameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Log1NameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(Log1PassBox.Text))
			{
				MessageBox.Show("Please Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Log1PassBox.Focus();
				return;
			}
			if (CatacomboBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please select category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				CatacomboBox.Focus();
				return;
			}
			string userName = Log1NameBox.Text;
			string userPassword = Log1PassBox.Text;
			string Category = CatacomboBox.SelectedItem.ToString();
			var Result = db.SignUps.Where(x => x.User_Name == userName && x.Password == userPassword&&x.Category_Admin==Category).Count();
			if (Result == 1)
			{
				this.Hide();
				Patient h = new Patient();
				h.Show();

			}
			else
			{
				MessageBox.Show("User Name Or Password or Category incorect", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void LogIn1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home();
			h.Show();
		}
	}
}
