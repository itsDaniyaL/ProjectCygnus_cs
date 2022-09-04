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
	public partial class Form14 : Form
	{
		public Form14()
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

		private void Form14_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT PID,Name,State,Ward FROM Patient WHERE CenterNo = '" + Form1.CenterNoBoxValue + "'";
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
			if (string.IsNullOrWhiteSpace(PatientIDBox.Text) || string.IsNullOrWhiteSpace(PerscriptionBox.Text))
			{
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if(con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT * FROM Patient WHERE CenterNo = '" + Form1.CenterNoBoxValue + "' AND PID = '" + PatientIDBox.Text.ToString() + "'";
				SqlCommand cmd = new SqlCommand(q, con);
				cmd.ExecuteNonQuery();
				Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
				if(countRecord == 1 && Condi)
				{
					q = "UPDATE Patient SET Perscribed = '" + PerscriptionBox.Text.ToString() + "' WHERE PID = '" + PatientIDBox.Text.ToString() + "'";
					cmd = new SqlCommand(q, con);
					cmd.ExecuteNonQuery();
				}
				else
				{
					Condi = false;
				}
			}
			if(!Condi)
			{
				label12.Show();
			}
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
