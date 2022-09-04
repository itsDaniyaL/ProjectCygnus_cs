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
	public partial class Form9 : Form
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

		public Form9()
		{
			InitializeComponent();
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form9_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT * FROM Quarantine";
				SqlDataAdapter Adap = new SqlDataAdapter(q, con);
				DataTable DT = new DataTable();
				Adap.Fill(DT);
				dataGridView1.DataSource = DT;
				dataGridView1.Show();

				q = "SELECT * FROM Isolation";
				Adap = new SqlDataAdapter(q, con);
				DT = new DataTable();
				Adap.Fill(DT);
				dataGridView2.DataSource = DT;
				dataGridView2.Show();
			}
		}

		private void Submit1B_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			if (string.IsNullOrWhiteSpace(CenterNo1Box.Text) || string.IsNullOrWhiteSpace(QuarantineWardNoBox.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "SELECT COUNT(*) FROM Center WHERE CenterNo = '" + CenterNo1Box.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
					if (countRecord == 0)
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
					string q = "INSERT INTO Quarantine(QID,CenterNo) VALUES ('" + CenterNo1Box.Text.ToString() + "', '" + QuarantineWardNoBox.Text.ToString() + "')";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();

					q = "SELECT * FROM Quarantine";
					SqlDataAdapter Adap = new SqlDataAdapter(q, con);
					DataTable DT = new DataTable();
					Adap.Fill(DT);
					dataGridView1.DataSource = DT;
					dataGridView1.Show();
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
			if (string.IsNullOrWhiteSpace(CenterNo2Box.Text) || string.IsNullOrWhiteSpace(IsolationWardNoBox.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "SELECT COUNT(*) FROM Center WHERE CenterNo = '" + CenterNo2Box.Text.ToString() + "'";
					SqlCommand cmd = new SqlCommand(q, con);
					Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
					if (countRecord == 0)
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
					string q = "INSERT INTO Quarantine(QID,CenterNo) VALUES ('" + CenterNo2Box.Text.ToString() + "', '" + IsolationWardNoBox.Text.ToString() + "')";
					SqlCommand cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();

					q = "SELECT * FROM Isolation";
					SqlDataAdapter Adap = new SqlDataAdapter(q, con);
					DataTable DT = new DataTable();
					Adap.Fill(DT);
					dataGridView2.DataSource = DT;
					dataGridView2.Show();
				}
			}
			else
			{
				label12.Show();
			}
		}
	}
}
