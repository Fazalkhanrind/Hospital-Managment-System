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
	public partial class Login : Form
	{

		HMSdbEntities7 db = new HMSdbEntities7();
		
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SignUp log = new SignUp();
			if (string.IsNullOrEmpty(LogNameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				LogNameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(LogPassBox.Text))
			{
				MessageBox.Show("Please Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				LogPassBox.Focus();
				return;
			}
			if (CatacomboBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please select category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				CatacomboBox.Focus();
				return;
			}

			string userName = LogNameBox.Text;
			string userPassword = LogPassBox.Text;
			string category = CatacomboBox.SelectedItem.ToString();
			
		     var Result = db.SignUps .Where(x => x.User_Name == userName && x.Password ==userPassword &&x.Category_Admin==category ).Count();
			if (Result==1)
			{
				 
				this.Hide();
				Doctor h = new Doctor();
				h.Show();

			}
			else
			{
				MessageBox.Show("User Name Or Password or category incorect", "Worning", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			SignUP s = new SignUP();
			s.Show();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
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
