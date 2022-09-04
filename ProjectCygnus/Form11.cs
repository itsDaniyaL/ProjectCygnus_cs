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
	public partial class Form11 : Form
	{
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

		public Form11()
		{
			InitializeComponent();
		}

		private void Form11_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT PID,Name,DOS FROM Patient WHERE Ward = 'Isolation' AND State = 'Infected'";
				SqlDataAdapter Adap = new SqlDataAdapter(q, con);
				DataTable DT = new DataTable();
				Adap.Fill(DT);
				dataGridView1.DataSource = DT;
				dataGridView1.Show();
			}
		}

		private void SubmitB_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				if (string.IsNullOrWhiteSpace(PickIDBox.Text) || (DeceasedR.Checked == true && QuarantineR.Checked == true))
				{
					Condi = false;
				}
				string q = "SELECT COUNT(*) FROM Patient WHERE PID = (SELECT PID FROM Patient WHERE State = 'Infected' AND Ward = 'Isolation')";
				SqlCommand cmd = new SqlCommand(q, con);
				Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
				if (countRecord == 1 && Condi)
				{
					if (DeceasedR.Checked == true || QuarantineR.Checked == false)
					{
						if (con.State == System.Data.ConnectionState.Open)
						{
							q = "UPDATE Patient SET Ward = NULL,State = 'Deceased',CenterNo = '" + Int32.Parse(Form1.CenterNoBoxValue) + "',DOS = GETDATE() WHERE PID = '" + Int32.Parse(PickIDBox.Text.ToString()) + "'";
							cmd = new SqlCommand(q, con);
							cmd.ExecuteNonQuery();
						}
					}
					else if (DeceasedR.Checked == false || QuarantineR.Checked == true)
					{
						if (con.State == System.Data.ConnectionState.Open)
						{
							q = "UPDATE Patient SET Ward = 'Quarantine',CenterNo = '" + Int32.Parse(Form1.CenterNoBoxValue) + "',DOS = GETDATE() WHERE PID = '" + Int32.Parse(PickIDBox.Text.ToString()) + "'";
							cmd = new SqlCommand(q, con);
							cmd.ExecuteNonQuery();
						}
					}
					if (con.State == System.Data.ConnectionState.Open)
					{
						q = "SELECT PID,Name,DOS FROM Patient WHERE Ward = 'Isolation' AND State = 'Infected'";
						SqlDataAdapter Adap = new SqlDataAdapter(q, con);
						DataTable DT = new DataTable();
						Adap.Fill(DT);
						dataGridView1.DataSource = DT;
						dataGridView1.Show();
					}
				}
				else
				{
					Condi = false;
				}
				if (!Condi)
				{
					label12.Show();
				}
			}
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
