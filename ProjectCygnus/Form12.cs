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
	public partial class Form12 : Form
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

		public Form12()
		{
			InitializeComponent();
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form12_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT EID,Name,Degree FROM Employee WHERE Name <> 'Source Code'";
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
			if(string.IsNullOrWhiteSpace(EmployeeIDBox.Text) || string.IsNullOrWhiteSpace(ReasonBox.Text))
			{
				MessageBox.Show("Hello1");
				Condi = false;
			}
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if(con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT COUNT(*) FROM Employee WHERE EID = '" + Int32.Parse(EmployeeIDBox.Text.ToString()) + "'";
				SqlCommand cmd = new SqlCommand(q, con);
				Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
				q = "SELECT COUNT(*) FROM Reported WHERE ReportedID = '" + Int32.Parse(EmployeeIDBox.Text.ToString()) + "'";
				cmd = new SqlCommand(q, con);
				Int32 countRecord1 = Convert.ToInt32(cmd.ExecuteScalar());
				MessageBox.Show("Hello");
				if(countRecord == 1 && Condi && countRecord1 == 0)
				{
					q = "INSERT INTO Reported(SenderID,SenderName,ReportedID,Reason) VALUES ('" + Int32.Parse(Form1.IDBoxValue) + "', '" + Form1.NameBoxValue + "', '" + Int32.Parse(EmployeeIDBox.Text.ToString()) + "', '" + ReasonBox.Text.ToString() + "')";
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
	}
}
