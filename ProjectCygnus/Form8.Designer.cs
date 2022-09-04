namespace ProjectCygnus
{
	partial class Form8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			this.ExitB = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.SubmitB = new System.Windows.Forms.Button();
			this.IDBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.IsolationR = new System.Windows.Forms.RadioButton();
			this.QuarantineR = new System.Windows.Forms.RadioButton();
			this.WardNoBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitB
			// 
			this.ExitB.Location = new System.Drawing.Point(743, 12);
			this.ExitB.Name = "ExitB";
			this.ExitB.Size = new System.Drawing.Size(45, 29);
			this.ExitB.TabIndex = 18;
			this.ExitB.Text = "X";
			this.ExitB.UseVisualStyleBackColor = true;
			this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel1.Controls.Add(this.label12);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 50);
			this.panel1.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(296, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(208, 25);
			this.label12.TabIndex = 55;
			this.label12.Text = "Fill Box(es) Correctly";
			this.label12.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 26);
			this.label1.TabIndex = 20;
			this.label1.Text = "Patients Pending:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Patient ID:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Pick Ward:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(337, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(401, 170);
			this.dataGridView1.TabIndex = 28;
			// 
			// SubmitB
			// 
			this.SubmitB.Location = new System.Drawing.Point(364, 353);
			this.SubmitB.Name = "SubmitB";
			this.SubmitB.Size = new System.Drawing.Size(75, 29);
			this.SubmitB.TabIndex = 29;
			this.SubmitB.Text = "Submit";
			this.SubmitB.UseVisualStyleBackColor = true;
			this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
			// 
			// IDBox
			// 
			this.IDBox.Location = new System.Drawing.Point(142, 173);
			this.IDBox.Name = "IDBox";
			this.IDBox.Size = new System.Drawing.Size(100, 22);
			this.IDBox.TabIndex = 31;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(722, 329);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(66, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// IsolationR
			// 
			this.IsolationR.AutoSize = true;
			this.IsolationR.Location = new System.Drawing.Point(142, 267);
			this.IsolationR.Name = "IsolationR";
			this.IsolationR.Size = new System.Drawing.Size(81, 21);
			this.IsolationR.TabIndex = 32;
			this.IsolationR.TabStop = true;
			this.IsolationR.Text = "Isolation";
			this.IsolationR.UseVisualStyleBackColor = true;
			// 
			// QuarantineR
			// 
			this.QuarantineR.AutoSize = true;
			this.QuarantineR.Location = new System.Drawing.Point(142, 317);
			this.QuarantineR.Name = "QuarantineR";
			this.QuarantineR.Size = new System.Drawing.Size(100, 21);
			this.QuarantineR.TabIndex = 33;
			this.QuarantineR.TabStop = true;
			this.QuarantineR.Text = "Quarantine";
			this.QuarantineR.UseVisualStyleBackColor = true;
			// 
			// WardNoBox
			// 
			this.WardNoBox.Location = new System.Drawing.Point(368, 290);
			this.WardNoBox.Name = "WardNoBox";
			this.WardNoBox.Size = new System.Drawing.Size(100, 22);
			this.WardNoBox.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(298, 293);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 34;
			this.label3.Text = "Ward No:";
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.WardNoBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.QuarantineR);
			this.Controls.Add(this.IsolationR);
			this.Controls.Add(this.IDBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.SubmitB);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ExitB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form8";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form8_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button SubmitB;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox IDBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton IsolationR;
		private System.Windows.Forms.RadioButton QuarantineR;
		private System.Windows.Forms.TextBox WardNoBox;
		private System.Windows.Forms.Label label3;
	}
}