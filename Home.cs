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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			 
			Login d = new Login();
			d.ShowDialog();
			this.Hide();
		}

		private void Home_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			 
			LogIn1 p = new LogIn1();
			p.ShowDialog();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			 
			Doctor_Login d = new Doctor_Login();
			d.ShowDialog();
			this.Hide();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			
			Login l = new Login();
			l.ShowDialog();

		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			IT_Login it = new IT_Login();
			it.Show();
		}
	}
}
