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
	public partial class Form5 : Form
	{
		public Form5()
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

		private void Form5_Load(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Close();
			WelcomeName.Text = Form1.NameBoxValue;
			NameU.Text = Form1.NameBoxValue;
			DOBU.Text = Form1.DOBBoxValue;
			AddressU.Text = Form1.AddressBoxValue;
			PhoneNoU.Text = Form1.PhoneNoBoxValue;
			DegreeU.Text = Form1.DegreeBoxValue;
		}
		
		private void ExitB_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SignOutB_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}

		private void PatientsPendingL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form8 f8 = new Form8();
			f8.ShowDialog();
		}

		private void IsolationWardL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form11 f11 = new Form11();
			f11.ShowDialog();
		}

		private void QuarantineWardL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form10 f10 = new Form10();
			f10.ShowDialog();
		}

		private void CurrentInfectedL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form13 f13 = new Form13();
			f13.ShowDialog();
		}

		private void PerscribePatientL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form14 f14 = new Form14();
			f14.ShowDialog();
		}

		private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form12 f12 = new Form12();
			f12.ShowDialog();
		}
	}
}
