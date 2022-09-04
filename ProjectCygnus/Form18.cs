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
	public partial class Form18 : Form
	{
		public Form18()
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

		public string conString = "Data Source=DESKTOP-5P0JGSL;Initial Catalog=ProjectCygnus;Integrated Security=True";

		private void Form18_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string q = "SELECT Perscribed FROM Patient WHERE PID = '" + Form1.IDBoxValue + "'";
				SqlCommand cmd = new SqlCommand(q, con);
				SqlDataReader Re = cmd.ExecuteReader();
				if(Re.Read())
				{
					Perscribed1L.Text = Re.GetValue(0).ToString();
				}
			}
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
