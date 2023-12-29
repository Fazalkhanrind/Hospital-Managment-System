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
	public partial class Doctor : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		DoctorTb1 model = new DoctorTb1();
		int id = 0;
		int a = 0;
		public Doctor()
		{
			InitializeComponent();
			DoctorView();
			//Doctorlable.Text =Convert.ToString(db.DoctorTb1.Count());
		}

		private void Home_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home();
			h.Show();
		}
		void DoctorView()
		{
			DocDataGridView.DataSource = db.DoctorTb1.ToList<DoctorTb1>();
		}
		void EmptyBox()
		{
			DocNameBox.Clear();
			DocRecomboBox.SelectedItem = null;
			DocPassBox.Clear();
			DocExpBox.Clear();

		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(DocNameBox.Text))
			{
				MessageBox.Show("Pleaz Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DocNameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(DocExpBox.Text))
			{
				MessageBox.Show("Pleaz Enter Expense!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DocExpBox.Focus();
				return;
			}
			if (DocRecomboBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please Doctor Category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DocRecomboBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(DocPassBox.Text))
			{
				MessageBox.Show("Pleaz Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				DocPassBox.Focus();
				return;
			}

			model.DocName = DocNameBox.Text.Trim();
			model.DocExp = Convert.ToInt32(DocExpBox.Text.Trim());
			model.DocDesination =DocRecomboBox.SelectedItem.ToString();
			model.DocPassword = DocPassBox.Text.Trim();
			db.DoctorTb1.Add(model);
			a=db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DoctorView();
				EmptyBox();
			}
			else
			{
				MessageBox.Show("Data inserted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void DocName_TextChanged(object sender, EventArgs e)
		{

		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			model.Docid = id;
			model.DocName = DocNameBox.Text.Trim();
			model.DocExp = Convert.ToInt32(DocExpBox.Text.Trim());
			model.DocDesination =DocRecomboBox.SelectedItem.ToString();
			model.DocPassword =DocPassBox.Text.Trim();
			db.Entry(model).State = System.Data.Entity.EntityState.Modified;
			int a = db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				 DoctorView();
				 EmptyBox();
			}
			else
			{
				MessageBox.Show("Data Updated  Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			EmptyBox();
		}

		private void DocDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			id = Convert.ToInt32(DocDataGridView.SelectedRows[0].Cells[0].Value);
			model = db.DoctorTb1.Where(m => m.Docid == id).FirstOrDefault();
			DocNameBox.Text = model.DocName;
			 DocExpBox.Text =model.DocExp.ToString();
			 DocRecomboBox.SelectedItem = model.DocDesination;
			DocPassBox.Text = model.DocPassword;
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult a = MessageBox.Show("Are you Soure Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (a == DialogResult.Yes)
			{
				model = db.DoctorTb1.Where(m => m.Docid == id).FirstOrDefault();
				db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
				int b = db.SaveChanges();
				if (b > 0)
				{
					MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					 DoctorView();
					 EmptyBox();
				}
				else
				{
					MessageBox.Show("Data Deleted  Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			string keyword = SeachtextBox.Text.Trim();
			DocDataGridView.DataSource = db.DoctorTb1.Where(a => a.DocName.Contains(keyword)).ToList();
		}

		private void Doctor_Load(object sender, EventArgs e)
		{
			 
		}

		private void ReportBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Report R = new Report();
			R.Show();
		}
	}
}
