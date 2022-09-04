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
	public partial class Form1 : Form
	{
		public Form1()
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

		public static string IDBoxValue = "";
		public static string NameBoxValue = "";
		public static string DOBBoxValue = "";
		public static string AddressBoxValue = "";
		public static string PhoneNoBoxValue = "";
		public static string DegreeBoxValue = "";
		public static string StateBoxValue = "";
		public static string CenterNoBoxValue = "";

		public string conString = "Data Source=DESKTOP-5P0JGSL;Initial Catalog=ProjectCygnus;Integrated Security=True";

		private void Form1_Load(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Close();
			Form3 f3 = new Form3();
			f3.Close();
			Form4 f4 = new Form4();
			f4.Close();
			Form5 f5 = new Form5();
			f5.Close();
			Form6 f6 = new Form6();
			f6.Close();
			Form7 f7 = new Form7();
			f7.Close();
			Form8 f8 = new Form8();
			f8.Close();
			PasswordBox.PasswordChar = '*';
		}

		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SignInB_Click(object sender, EventArgs e)
		{
			bool Done = false;
			string Name = "", Password = "";
			bool Condi = false;
			SqlConnection con = new SqlConnection(conString);
			con.Open();
			if(string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
			{
				Condi = true;
			}
			if (!Condi)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "SELECT COUNT(*) FROM Employee WHERE Name = '" + NameBox.Text.ToString() + "' AND Password =  HASHBYTES('SHA','" + PasswordBox.Text.ToString() + "')";
					SqlCommand cmd = new SqlCommand(q, con);
					Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
					if (countRecord == 1)
					{
						Condi = false;
						q = "SELECT EID,Name,Password,DOB,Address,PhoneNo,Degree,CenterNo FROM Employee WHERE Name = '" + NameBox.Text.ToString() + "' AND Password =  HASHBYTES('SHA','" + PasswordBox.Text.ToString() + "')";
						cmd = new SqlCommand(q, con);
						SqlDataReader Re = cmd.ExecuteReader();
						while (Re.Read())
						{
							IDBoxValue = Re.GetValue(0).ToString();
							NameBoxValue = NameBox.Text;
							DOBBoxValue = Re.GetValue(3).ToString();
							AddressBoxValue = Re.GetValue(4).ToString();
							PhoneNoBoxValue = Re.GetValue(5).ToString();
							DegreeBoxValue = Re.GetValue(6).ToString();
							CenterNoBoxValue = Re.GetValue(7).ToString();
							Name = NameBox.Text;
						}
						if (Name == "Source Code" && PasswordBox.Text == "123456789")
						{
							Condi = false;
							Form6 f6 = new Form6();
							f6.ShowDialog();
						}
						else
						{
							Condi = false;
							Form f5 = new Form5();
							f5.ShowDialog();
						}
						Done = true;
					}
					else
					{
						Condi = true;
					}
				}
			}
			if (!Done)
			{
				if (con.State == System.Data.ConnectionState.Open)
				{
					string q = "SELECT PID,Name,DOB,Address,State,PhoneNo FROM Patient WHERE Name = '" + NameBox.Text.ToString() + "' AND Password =  HASHBYTES('SHA','" + PasswordBox.Text.ToString() + "')";
					SqlCommand cmd = new SqlCommand(q, con);
					Int32 countRecord = Convert.ToInt32(cmd.ExecuteScalar());
					if (countRecord == 1)
					{
						Condi = false;
						SqlDataReader Re = cmd.ExecuteReader();
						while (Re.Read())
						{
							IDBoxValue = Re.GetValue(0).ToString();
							NameBoxValue = Re.GetValue(1).ToString();
							DOBBoxValue = Re.GetValue(2).ToString();
							AddressBoxValue = Re.GetValue(3).ToString();
							StateBoxValue = Re.GetValue(4).ToString();
							PhoneNoBoxValue = Re.GetValue(5).ToString();
							NameBoxValue = NameBox.Text;
						}
						Form3 f3 = new Form3();
						f3.ShowDialog();
					}
					else
					{
						Condi = true;
					}
				}
			}
			if(Condi)
			{
				label3.Show();
			}
			else
			{
				label3.Hide();
			}
		}

		private void SignUpPB_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void SignUpEB_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.ShowDialog();
		}

		private void NameBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
