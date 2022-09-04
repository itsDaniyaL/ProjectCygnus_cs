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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		string conString = "Data Source=DESKTOP-5P0JGSL;Initial Catalog=ProjectCygnus;Integrated Security=True";

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

		private void Form6_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT EID,Name,Address,JobTitle,Degree FROM Employee WHERE Hire = 'No'";
				SqlDataAdapter Adap = new SqlDataAdapter(q, con);
				DataTable DT = new DataTable();
				Adap.Fill(DT);
				dataGridView1.DataSource = DT;
				dataGridView1.Show();

				q = "SELECT * FROM Reported";
				Adap = new SqlDataAdapter(q, con);
				DT = new DataTable();
				Adap.Fill(DT);
				dataGridView2.DataSource = DT;
				dataGridView2.Show();

				q = "SELECT EID,Name,Degree FROM Employee WHERE Name <> 'Source Code'";
				Adap = new SqlDataAdapter(q, con);
				DT = new DataTable();
				Adap.Fill(DT);
				dataGridView3.DataSource = DT;
				dataGridView3.Show();
			}
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Submit1B_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if(string.IsNullOrWhiteSpace(IDBox.Text) || string.IsNullOrWhiteSpace(CenterNoBox.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "UPDATE Employee SET CenterNo = '" + CenterNoBox.Text.ToString() + "', Hire = 'Yes' WHERE EID = '" + IDBox.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
			}
			else
			{
				label12.Show();
			}
		}

		private void Submit2B_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if (string.IsNullOrWhiteSpace(ID1Box.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "SELECT COUNT(*) FROM Reported WHERE SenderID = '" + ID1Box.Text.ToString() +"' OR ReportedID = '" + ID1Box.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
					if(countRecord == 0)
					{
						Condi = false;
					}
					cmd.ExecuteNonQuery();
				}
			}
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "DELETE FROM Employee WHERE EID = '" + ID1Box.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
			}
			else
			{
				label12.Show();
			}
		}

		private void Submit3B_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if (string.IsNullOrWhiteSpace(ID2Box.Text) || string.IsNullOrWhiteSpace(CenterNoBox.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "DELETE FROM Employee WHERE EID = '" + ID2Box.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
			}
			else
			{
				label12.Show();
			}
		}

		private void Submit4B_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if (string.IsNullOrWhiteSpace(CenterNo1Box.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "INSERT INTO Center(CenterNo) VALUES ('" + CenterNo1Box.Text.ToString() + "')";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
			}
			else
			{
				label12.Show();
			}
		}

		private void PressB_Click(object sender, EventArgs e)
		{
			Form9 f9 = new Form9();
			f9.ShowDialog();
		}
	}
}
