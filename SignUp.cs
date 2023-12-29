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
	public partial class SignUP : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		SignUp sign = new SignUp();
		public SignUP()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(SignNameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SignNameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(SignEmailBox.Text))
			{
				MessageBox.Show("Please Enter Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SignEmailBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty( SignPassBox.Text))
			{
				MessageBox.Show("Please Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SignPassBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(SignConPassBox.Text))
			{
				MessageBox.Show("Please Enter Conform Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SignConPassBox.Focus();
				return;
			}
			if (AdmincomboBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please select category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				AdmincomboBox.Focus();
				return;
			}
			sign.User_Name = SignNameBox.Text.Trim();
			sign.User_Email = SignEmailBox.Text.Trim();
			sign.Password = SignPassBox.Text.Trim();
			sign.Conform_Password = SignConPassBox.Text.Trim();
			sign.Category_Admin = AdmincomboBox.SelectedItem.ToString();
			db.SignUps.Add(sign);
			int a = db.SaveChanges();
			if (a > 0)
			{
				
				MessageBox.Show("SignUp Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
				Home l = new Home();
				l.Show();

			}
			else
			{
				MessageBox.Show("SigUp Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			

		}

		private void SignUP_Load(object sender, EventArgs e)
		{

		}
	}
}
