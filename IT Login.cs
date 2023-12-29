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
	public partial class IT_Login : Form
	{
		public IT_Login()
		{
			InitializeComponent();
		}

		private void LogBtn_Click(object sender, EventArgs e)
		{
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
			string name = LogNameBox.Text.Trim();
			string pass = LogPassBox.Text.Trim();
			if (name == "King" & pass == "84606")
			{
				
				this.Hide();
				SignUP s = new SignUP();
				s.Show();

			}
			else
			{
				MessageBox.Show("User Name or Password are Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void IT_Login_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
			SignUP s = new SignUP();
			s.Show();
		}
	}
}
