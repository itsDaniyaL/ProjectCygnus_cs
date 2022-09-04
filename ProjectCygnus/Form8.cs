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
	public partial class Form8 : Form
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

		public Form8()
		{
			InitializeComponent();
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SubmitB_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT COUNT(*) FROM Patient WHERE PID = (SELECT PID FROM Patient WHERE State = 'Infected')";
				SqlCommand cmd = new SqlCommand(q, con);
				Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
				q = "SELECT COUNT(*) FROM Quarantine WHERE QID = '" + WardNoBox.Text.ToString() + "'";
				cmd = new SqlCommand(q, con);
				Int32 countRecord1 = Convert.ToInt32(cmd.ExecuteScalar());
				q = "SELECT COUNT(*) FROM Isolation WHERE IID = '" + WardNoBox.Text.ToString() + "'";
				cmd = new SqlCommand(q, con);
				Int32 countRecord2 = Convert.ToInt32(cmd.ExecuteScalar());
				if (countRecord == 1 && (countRecord1 == 1 || countRecord2 == 1))
				{
					if (string.IsNullOrWhiteSpace(IDBox.Text) || (IsolationR.Checked == true && QuarantineR.Checked == true) || string.IsNullOrWhiteSpace(WardNoBox.Text))
					{
						Condi = false;
					}
					else if (IsolationR.Checked == true || QuarantineR.Checked == false)
					{
						if (con.State == System.Data.ConnectionState.Open)
						{
							q = "UPDATE Patient SET Ward = 'Isolation',IID = '" + Int32.Parse(WardNoBox.Text.ToString()) + "',QID = NULL,EID = '" + Int32.Parse(Form1.IDBoxValue) + "',CenterNo = '" + Int32.Parse(Form1.CenterNoBoxValue) + "',DOS = GETDATE() WHERE PID = '" + IDBox.Text.ToString() + "'";
							cmd = new SqlCommand(q, con);
							cmd.ExecuteNonQuery();
						}
					}
					else if (IsolationR.Checked == false || QuarantineR.Checked == true)
					{
						if (con.State == System.Data.ConnectionState.Open)
						{
							q = "UPDATE Patient SET Ward = 'Quarantine', QID = '" + Int32.Parse(WardNoBox.Text.ToString()) + "',IID = NULL,EID = '" + Int32.Parse(Form1.IDBoxValue) + "',CenterNo = '" + Int32.Parse(Form1.CenterNoBoxValue) + "',DOS = GETDATE() WHERE PID = '" + IDBox.Text.ToString() + "'";
							cmd = new SqlCommand(q, con);
							cmd.ExecuteNonQuery();
						}
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

		private void Form8_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT PID,Name,State,Ward FROM Patient WHERE State = 'Infected'";
				SqlDataAdapter Adap = new SqlDataAdapter(q, con);
				DataTable DT = new DataTable();
				Adap.Fill(DT);
				dataGridView1.DataSource = DT;
				dataGridView1.Show();
			}
		}
	}
}
