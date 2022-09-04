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
	public partial class Form3 : Form
	{
		public Form3()
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

		private void Form3_Load(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Close();
			pictureBox1.Show();
			WelcomeName.Text = Form1.NameBoxValue;
			NameU.Text = Form1.NameBoxValue;
			DOBU.Text = Form1.DOBBoxValue;
			AddressU.Text = Form1.AddressBoxValue;
			StateU.Text = Form1.StateBoxValue;
			PhoneNoU.Text = Form1.PhoneNoBoxValue;
		}
		
		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SignOutB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SymptomsL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form7 f7 = new Form7();
			f7.ShowDialog();
		}

		private void CurrentL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form13 f13 = new Form13();
			f13.ShowDialog();
		}

		private void PreventionL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form15 f15 = new Form15();
			f15.ShowDialog();
		}

		private void IsolationL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form17 f17 = new Form17();
			f17.ShowDialog();
		}

		private void QuarantineL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form16 f16 = new Form16();
			f16.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form18 f18 = new Form18();
			f18.ShowDialog();
		}
	}
}
