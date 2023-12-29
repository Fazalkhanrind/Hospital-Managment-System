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
	public partial class Doctor_Login : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		DoctorTb1 doc = new DoctorTb1();
		public static string name;
		public static string catagory;
		public Doctor_Login()
		{
			InitializeComponent();
		}

		private void DoclogBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(DoclogNameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DoclogNameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(DoclogNameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DoclogNameBox.Focus();
				return;
			}
			if (DocCatacomboBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select Doctor Category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DocCatacomboBox.Focus();
				return;
			}

			name = DoclogNameBox.Text.Trim();
			catagory = DocCatacomboBox.SelectedItem.ToString();

			
			var Result = db.DoctorTb1.Where(x => x.DocName ==DoclogNameBox.Text  && x.DocPassword ==DocLogPassBox.Text&& x.DocDesination==DocCatacomboBox.SelectedItem.ToString()).Count();
			if (Result == 1)
			{
				 
				this.Hide();
			 Diagonsis h = new  Diagonsis();
				h.Show();

			}
			else
			{
				MessageBox.Show("User Name Or Password incorect", "Worning", MessageBoxButtons.OK);
			}
		}

		private void Doctor_Login_Load(object sender, EventArgs e)
		{
			//using (var my = new HMSdbEntities7())
			//{
			//	var  Doc = from p in my.DoctorTb1 select p.DocDesination;
			//	DocCatacomboBox.Items.AddRange(Doc.ToArray());

			//}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
