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
	public partial class Patient : Form
	{
		HMSdbEntities7 db = new HMSdbEntities7();
		PatientTb1 model = new PatientTb1();
		int a = 0;
		int id = 0;

		public Patient()
		{
			InitializeComponent();
			PatientView();
			string keyword = SeachtextBox.Text.Trim();
			PatientGridView.DataSource = db.PatientTb1.Where(a => a.PatName.Contains(keyword) || a.PatPhone.Contains(keyword)).ToList();
		}
		void PatientView()
		{
			PatientGridView.DataSource = db.PatientTb1.ToList<PatientTb1>();
		}
		void EmptyBox()
		{
			PatNameBox.Clear();
			PatPhoneBox.Clear();
			PatAddressBox.Clear();
			DocRecomboBox.SelectedItem=null;
			PatAgeBox.Clear();
			PatBloodCombBox.SelectedItem = null;
			PatGenderComBox.SelectedItem = null;

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void Patient_Load(object sender, EventArgs e)
		{
			 
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home();
			h.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(PatNameBox.Text))
			{
				MessageBox.Show("Please Enter Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatNameBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(PatAddressBox.Text))
			{
				MessageBox.Show("Please Enter Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatAddressBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(PatAgeBox.Text))
			{
				MessageBox.Show("Please Enter Age!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatAgeBox.Focus();
				return;
			}
			if (string.IsNullOrEmpty(PatPhoneBox.Text))
			{
				MessageBox.Show("Please Enter Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatPhoneBox.Focus();
				return;
			}

			if (PatGenderComBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatGenderComBox.Focus();
				return;
			}
			if (PatBloodCombBox.SelectedIndex == -1)
			{
				MessageBox.Show("Please Select Blood group!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				PatBloodCombBox.Focus();
				return;
			}
			model.PatName = PatNameBox.Text.Trim();
			model.PatAddress = PatAddressBox.Text.Trim();
			model.PatPhone = PatPhoneBox.Text.Trim();
			model.PatAge = Convert.ToInt32(PatAgeBox.Text.Trim());
			model.PatDisease =DocRecomboBox.SelectedItem.ToString();
			model.PatGender = PatGenderComBox.SelectedItem.ToString();
			model.PatBlood = PatBloodCombBox.SelectedItem.ToString();
			db.PatientTb1.Add(model);
			a = db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PatientView();
				EmptyBox();
			}
			else
			{
				MessageBox.Show("Data inserted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			EmptyBox();
		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			model.PatId = id;
			model.PatName = PatNameBox.Text.Trim();
			model.PatAddress = PatAddressBox.Text.Trim();
			model.PatDisease = DocRecomboBox.SelectedItem.ToString();
			model.PatAge = Convert.ToInt32(PatAgeBox.Text.Trim());
			model.PatPhone = PatPhoneBox.Text.Trim();
			model.PatBlood = PatBloodCombBox.SelectedItem.ToString();
			model.PatGender = PatGenderComBox.SelectedItem.ToString();
			db.Entry(model).State = System.Data.Entity.EntityState.Modified;
			int a = db.SaveChanges();
			if (a > 0)
			{
				MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				PatientView();
				EmptyBox();
			}
			else
			{
				MessageBox.Show("Data Updated  Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void PatientGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			id = Convert.ToInt32(PatientGridView.SelectedRows[0].Cells[0].Value);
			model = db.PatientTb1.Where(m => m.PatId == id).FirstOrDefault();
			PatNameBox.Text = model.PatName;
			PatPhoneBox.Text = model.PatPhone;
			PatAddressBox.Text = model.PatAddress;
			DocRecomboBox.SelectedItem = model.PatDisease;
			PatAgeBox.Text = model.PatAge.ToString();
			PatBloodCombBox.SelectedItem = model.PatBlood;
			PatGenderComBox.SelectedItem = model.PatGender;

		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult a = MessageBox.Show("Are you Soure Delete", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (a == DialogResult.Yes)
			{
				model = db.PatientTb1.Where(m => m.PatId == id).FirstOrDefault();
				db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
				int b = db.SaveChanges();
				if (b > 0)
				{
					MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					PatientView();
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
			PatientGridView.DataSource = db.PatientTb1.Where(a => a.PatName.Contains(keyword)||a.PatPhone.Contains(keyword)).ToList();
		}
	}

}
