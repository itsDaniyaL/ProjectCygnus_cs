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
	public partial class Form16 : Form
	{
		public Form16()
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

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form16_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT Name,State,Ward,CenterNo,QID FROM Patient WHERE CenterNo = '" + Form1.CenterNoBoxValue + "' AND Ward = 'Quarantine'";
				SqlDataAdapter Adap = new SqlDataAdapter(q, con);
				DataTable DT = new DataTable();
				Adap.Fill(DT);
				dataGridView2.DataSource = DT;
				dataGridView2.Show();
			}
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
