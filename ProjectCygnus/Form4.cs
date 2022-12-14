using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCygnus
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
						m.Result = (IntPtr)0x2;
					return;
			}

			base.WndProc(ref m);
		}

		string conString = "Data Source=DESKTOP-5P0JGSL;Initial Catalog=ProjectCygnus;Integrated Security=True";

		private void Form4_Load(object sender, EventArgs e)
		{
			PasswordBox.PasswordChar = '*';
		}
		
		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SubmitB_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text) || string.IsNullOrWhiteSpace(JobTitleBox.Text))
			{
				Condi = false;
			}
			if (string.IsNullOrWhiteSpace(AddressBox.Text))
			{
				AddressBox.Text = "NULL";
			}
			if (string.IsNullOrWhiteSpace(CNICBox.Text))
			{
				CNICBox.Text = "NULL";
			}
			if (string.IsNullOrWhiteSpace(PhoneNoBox.Text))
			{
				PhoneNoBox.Text = "NULL";
			}
			if (string.IsNullOrWhiteSpace(DOBBox.Text))
			{
				DOBBox.Text = "NULL";
			}
			if (string.IsNullOrWhiteSpace(DegreeBox.Text))
			{
				DegreeBox.Text = "NULL";
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "INSERT INTO Employee(Name,Password,Address,CNIC,PhoneNo,DOB,JobTitle,Degree,CenterNo,Hire) VALUES ('" + NameBox.Text.ToString() + "',HASHBYTES('SHA','" + PasswordBox.Text.ToString() + "'),'" + AddressBox.Text.ToString() + "','" + CNICBox.Text.ToString() + "','" + PhoneNoBox.Text.ToString() + "','" + DOBBox.Text.ToString() + "','" + JobTitleBox.Text.ToString() + "','" + DegreeBox.Text.ToString() + "', NULL, 'No')";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
			}
			else
			{
				label11.Show();
			}
		}
	}
}
