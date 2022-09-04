namespace ProjectCygnus
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ExitB = new System.Windows.Forms.Button();
			this.SignInB = new System.Windows.Forms.Button();
			this.SignUpPB = new System.Windows.Forms.Button();
			this.SignUpEB = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign In";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(86, 98);
			this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(93, 20);
			this.NameBox.TabIndex = 1;
			this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 100);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 231);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(430, 33);
			this.panel1.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(178, 6);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Not Found";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 206);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "New to Cygnus?";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 129);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Password:";
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(86, 129);
			this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new System.Drawing.Size(76, 20);
			this.PasswordBox.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(200, 206);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "OR";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(251, 206);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "For Employees:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(254, 38);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(152, 158);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// ExitB
			// 
			this.ExitB.Location = new System.Drawing.Point(388, 10);
			this.ExitB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ExitB.Name = "ExitB";
			this.ExitB.Size = new System.Drawing.Size(34, 24);
			this.ExitB.TabIndex = 16;
			this.ExitB.Text = "X";
			this.ExitB.UseVisualStyleBackColor = true;
			this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
			// 
			// SignInB
			// 
			this.SignInB.Location = new System.Drawing.Point(86, 162);
			this.SignInB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SignInB.Name = "SignInB";
			this.SignInB.Size = new System.Drawing.Size(56, 24);
			this.SignInB.TabIndex = 17;
			this.SignInB.Text = "Sign In";
			this.SignInB.UseVisualStyleBackColor = true;
			this.SignInB.Click += new System.EventHandler(this.SignInB_Click);
			// 
			// SignUpPB
			// 
			this.SignUpPB.Location = new System.Drawing.Point(105, 202);
			this.SignUpPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SignUpPB.Name = "SignUpPB";
			this.SignUpPB.Size = new System.Drawing.Size(56, 24);
			this.SignUpPB.TabIndex = 18;
			this.SignUpPB.Text = "Sign Up";
			this.SignUpPB.UseVisualStyleBackColor = true;
			this.SignUpPB.Click += new System.EventHandler(this.SignUpPB_Click);
			// 
			// SignUpEB
			// 
			this.SignUpEB.Location = new System.Drawing.Point(335, 202);
			this.SignUpEB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SignUpEB.Name = "SignUpEB";
			this.SignUpEB.Size = new System.Drawing.Size(56, 24);
			this.SignUpEB.TabIndex = 19;
			this.SignUpEB.Text = "Sign Up";
			this.SignUpEB.UseVisualStyleBackColor = true;
			this.SignUpEB.Click += new System.EventHandler(this.SignUpEB_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(430, 264);
			this.Controls.Add(this.SignUpEB);
			this.Controls.Add(this.SignUpPB);
			this.Controls.Add(this.SignInB);
			this.Controls.Add(this.ExitB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sign In - Cygnus";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button ExitB;
		private System.Windows.Forms.Button SignInB;
		private System.Windows.Forms.Button SignUpPB;
		private System.Windows.Forms.Button SignUpEB;
	}
}

