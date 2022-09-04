namespace ProjectCygnus
{
	partial class Form12
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
			this.ExitB = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SubmitB = new System.Windows.Forms.Button();
			this.EmployeeIDBox = new System.Windows.Forms.TextBox();
			this.ReasonBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitB
			// 
			this.ExitB.Location = new System.Drawing.Point(743, 12);
			this.ExitB.Name = "ExitB";
			this.ExitB.Size = new System.Drawing.Size(45, 29);
			this.ExitB.TabIndex = 62;
			this.ExitB.Text = "X";
			this.ExitB.UseVisualStyleBackColor = true;
			this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 50);
			this.panel1.TabIndex = 60;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(119, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(530, 17);
			this.label4.TabIndex = 66;
			this.label4.Text = "This will be recorded. Reporting false report may end up taking actions against y" +
    "ou";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 26);
			this.label1.TabIndex = 63;
			this.label1.Text = "Report Employee:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 239);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 17);
			this.label2.TabIndex = 64;
			this.label2.Text = "Employee ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 295);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 65;
			this.label3.Text = "Reason:";
			// 
			// SubmitB
			// 
			this.SubmitB.Location = new System.Drawing.Point(143, 350);
			this.SubmitB.Name = "SubmitB";
			this.SubmitB.Size = new System.Drawing.Size(75, 31);
			this.SubmitB.TabIndex = 66;
			this.SubmitB.Text = "Submit";
			this.SubmitB.UseVisualStyleBackColor = true;
			this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
			// 
			// EmployeeIDBox
			// 
			this.EmployeeIDBox.Location = new System.Drawing.Point(143, 236);
			this.EmployeeIDBox.Name = "EmployeeIDBox";
			this.EmployeeIDBox.Size = new System.Drawing.Size(100, 22);
			this.EmployeeIDBox.TabIndex = 67;
			// 
			// ReasonBox
			// 
			this.ReasonBox.Location = new System.Drawing.Point(143, 292);
			this.ReasonBox.Name = "ReasonBox";
			this.ReasonBox.Size = new System.Drawing.Size(371, 22);
			this.ReasonBox.TabIndex = 68;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 82);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(265, 127);
			this.dataGridView1.TabIndex = 71;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(536, 82);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(203, 195);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 70;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(559, 278);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(156, 67);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 69;
			this.pictureBox2.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(241, 356);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(208, 25);
			this.label12.TabIndex = 67;
			this.label12.Text = "Fill Box(es) Correctly";
			this.label12.Visible = false;
			// 
			// Form12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.ReasonBox);
			this.Controls.Add(this.EmployeeIDBox);
			this.Controls.Add(this.SubmitB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitB);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form12";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form12";
			this.Load += new System.EventHandler(this.Form12_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SubmitB;
		private System.Windows.Forms.TextBox EmployeeIDBox;
		private System.Windows.Forms.TextBox ReasonBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label12;
	}
}