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
	public partial class Form7 : Form
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

		public string conString = "Data Source=DESKTOP-5P0JGSL;Initial Catalog=ProjectCygnus;Integrated Security=True";

		public Form7()
		{
			InitializeComponent();
		}
		
		private void SubmitB_Click(object sender, EventArgs e)
		{
			bool Condi = true;
			int Check = 0;
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if(Form1.StateBoxValue == "Infected")
			{
				label7.Show();
				Condi = false;
			}
			if(string.IsNullOrWhiteSpace(FeverBox.Text))
			{
				FeverBox.Text = "No";
			}
			if (string.IsNullOrWhiteSpace(HeadAcheBox.Text))
			{
				FeverBox.Text = "No";
			}
			if (string.IsNullOrWhiteSpace(SoreThroatBox.Text))
			{
				FeverBox.Text = "No";
			}
			if (string.IsNullOrWhiteSpace(BreathingDifficultyBox.Text))
			{
				FeverBox.Text = "No";
			}
			if (string.IsNullOrWhiteSpace(ChestPainBox.Text))
			{
				FeverBox.Text = "No";
			}
			if(con.State == System.Data.ConnectionState.Open && Condi)
			{
				string q = "INSERT INTO Symptoms(PID,Fever,HeadAche,SoreThroat,BreathingDifficulty,ChestPain) VALUES ('" + Form1.IDBoxValue + "','" + FeverBox.Text.ToString() + "','" + HeadAcheBox.Text.ToString() + "','" + SoreThroatBox.Text.ToString() + "','" + BreathingDifficultyBox.Text.ToString() + "','" + ChestPainBox.Text.ToString() + "')";
				SqlCommand cmd = new SqlCommand(q, con);
				cmd.ExecuteNonQuery();
			}
			if(FeverBox.Text == "Yes")
			{
				Check++;
			}
			if (HeadAcheBox.Text == "Yes")
			{
				Check++;
			}
			if (SoreThroatBox.Text == "Yes")
			{
				Check++;
			}
			if (BreathingDifficultyBox.Text == "Yes")
			{
				Check++;
			}
			if (ChestPainBox.Text == "Yes")
			{
				Check++;
			}
			if(Check > 2 && con.State == System.Data.ConnectionState.Open)
			{
				string q = "UPDATE Patient SET State = 'Infected' WHERE PID = '" + Form1.IDBoxValue + "'";
				SqlCommand cmd = new SqlCommand(q, con);
				cmd.ExecuteNonQuery();
			}
			else
			{
				string q = "UPDATE Patient SET State = 'Check-Up' WHERE PID = '" + Form1.IDBoxValue + "'";
				SqlCommand cmd = new SqlCommand(q, con);
				cmd.ExecuteNonQuery();
			}
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
