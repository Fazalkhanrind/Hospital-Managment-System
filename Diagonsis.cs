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
	public partial class Diagonsis : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		DiagonsisTb1 model = new DiagonsisTb1();
		DoctorTb1 doc = new DoctorTb1();
		PatientTb1 pat = new PatientTb1();
		int a = 0;
		int id = 0;
		 
		public Diagonsis()
		{
			InitializeComponent();
			DrNameLable.Text = Doctor_Login.name;
			 
			DiagView();

		}
		void DiagView()
		{
			//string A = Doctor_Login.catagory;
			//var data = db.DiagonsisTb1.Where(m => m.DocPatCategory == A).Select(m => m.DocPatCategory).ToList();
			DiagGridView.DataSource = db.DiagonsisTb1.ToList();
		}
		void EmptyBox()
		{
			comboBox1.SelectedItem = null; 
			MedicinBox.Clear();
			SymBox.Clear();
		}

		private void DiaHomeBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home();
			h.Show();
		}

		private void Diagonsis_Load(object sender, EventArgs e)
		{
			string c = Doctor_Login.catagory;
		 
			
				var Category = db.PatientTb1.Where(m => m.PatDisease == c).Select(s => s.PatName).ToList();
				comboBox1.Items.AddRange(Category.ToArray());
			
			
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			 
			if (comboBox1.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select Patient Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboBox1.Focus();
				return;
			}
			if (string.IsNullOrEmpty(SymBox.Text))
			{
				MessageBox.Show("Please Enter Symptoms!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SymBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(MedicinBox.Text))
			{
				MessageBox.Show("Please Enter Medicine!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				MedicinBox.Focus();
				return;
			}
			model.PatName = comboBox1.SelectedItem.ToString();
			model.DocName = Doctor_Login.name;
			model.Symptoms = SymBox.Text.Trim();
			model.Medicine = MedicinBox.Text.Trim();
			model.DocPatCategory = Doctor_Login.catagory;
			db.DiagonsisTb1.Add(model);
			a = db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DiagView();
				EmptyBox();
				Patlabel.Text = model.PatName;
				Doclabel.Text = model.DocName;
				Syslabel.Text = model.Symptoms;
				Mediclabel.Text = model.Medicine;
				Datelabel.Text = DateTime.Now.ToLongDateString();

			}
			else
			{
				MessageBox.Show("Data inserted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			model.ReportId = id;
			model.DocName = Doctor_Login.name;
			model.PatName = comboBox1.SelectedItem.ToString();
			model.Medicine = MedicinBox.Text.Trim();
			model.Symptoms = SymBox.Text.Trim();
			model.DocPatCategory = Doctor_Login.catagory;
			db.Entry(model).State = System.Data.Entity.EntityState.Modified;
			int a = db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DiagView();
				EmptyBox();
				Patlabel.Text = model.PatName;
				Doclabel.Text = model.DocName;
				Syslabel.Text = model.Symptoms;
				Mediclabel.Text = model.Medicine;
				Datelabel.Text = DateTime.Now.ToLongDateString();
			}
			else
			{
				MessageBox.Show("Data Updated  Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult a = MessageBox.Show("Are you Soure Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (a == DialogResult.Yes)
			{
				model = db.DiagonsisTb1.Where(m => m.ReportId == id).FirstOrDefault();
				db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
				int b = db.SaveChanges();
				if (b > 0)
				{
					MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DiagView();
					EmptyBox();
				}
				else
				{
					MessageBox.Show("Data Deleted  Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			EmptyBox();
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			string keyword = SearchtextBox.Text.Trim();
			DiagGridView.DataSource = db.DiagonsisTb1.Where(a => a.PatName.Contains(keyword)).ToList();
		}
		Bitmap bmp;
		private void printBtn_Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
			//Graphics g = this.CreateGraphics();
			//bmp = new Bitmap(this.Size.Width, this.Size.Width, g);
			//Graphics mg = Graphics.FromImage(bmp);
			//mg.CopyFromScreen(this.Location.X, this.Location.Y,0, -10, this.Size);
			//printPreviewDialog1.ShowDialog();
		}

		private void DiagGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			id = Convert.ToInt32(DiagGridView.SelectedRows[0].Cells[0].Value);
			model = db.DiagonsisTb1.Where(m => m.ReportId == id).FirstOrDefault();
			 
			comboBox1.Text = model.PatName;
			MedicinBox.Text = model.Medicine;
			SymBox.Text = model.Symptoms;
			Patlabel.Text = model.PatName;
			Doclabel.Text = model.DocName;
			Syslabel.Text = model.Symptoms;
			Mediclabel.Text = model.Medicine;

			Datelabel.Text = DateTime.Now.ToLongDateString();

		}
		 
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			//e.Graphics.DrawImage(bmp, 100, 100);
		}

		private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("", new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10,10));
		}
	}
}
