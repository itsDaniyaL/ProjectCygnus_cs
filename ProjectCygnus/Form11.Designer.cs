namespace ProjectCygnus
{
	partial class Form11
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
			this.QuarantineR = new System.Windows.Forms.RadioButton();
			this.DeceasedR = new System.Windows.Forms.RadioButton();
			this.PickIDBox = new System.Windows.Forms.TextBox();
			this.SubmitB = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ExitB = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// QuarantineR
			// 
			this.QuarantineR.AutoSize = true;
			this.QuarantineR.Location = new System.Drawing.Point(95, 204);
			this.QuarantineR.Name = "QuarantineR";
			this.QuarantineR.Size = new System.Drawing.Size(100, 21);
			this.QuarantineR.TabIndex = 67;
			this.QuarantineR.TabStop = true;
			this.QuarantineR.Text = "Quarantine";
			this.QuarantineR.UseVisualStyleBackColor = true;
			// 
			// DeceasedR
			// 
			this.DeceasedR.AutoSize = true;
			this.DeceasedR.Location = new System.Drawing.Point(95, 176);
			this.DeceasedR.Name = "DeceasedR";
			this.DeceasedR.Size = new System.Drawing.Size(93, 21);
			this.DeceasedR.TabIndex = 66;
			this.DeceasedR.TabStop = true;
			this.DeceasedR.Text = "Deceased";
			this.DeceasedR.UseVisualStyleBackColor = true;
			// 
			// PickIDBox
			// 
			this.PickIDBox.Location = new System.Drawing.Point(95, 110);
			this.PickIDBox.Name = "PickIDBox";
			this.PickIDBox.Size = new System.Drawing.Size(100, 22);
			this.PickIDBox.TabIndex = 65;
			// 
			// SubmitB
			// 
			this.SubmitB.Location = new System.Drawing.Point(120, 263);
			this.SubmitB.Name = "SubmitB";
			this.SubmitB.Size = new System.Drawing.Size(75, 31);
			this.SubmitB.TabIndex = 64;
			this.SubmitB.Text = "Submit";
			this.SubmitB.UseVisualStyleBackColor = true;
			this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(17, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 63;
			this.label3.Text = "Pick One:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(17, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 62;
			this.label2.Text = "Pick ID:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(331, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(457, 253);
			this.dataGridView1.TabIndex = 61;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 26);
			this.label1.TabIndex = 60;
			this.label1.Text = "Isolation Ward:";
			// 
			// ExitB
			// 
			this.ExitB.Location = new System.Drawing.Point(743, 6);
			this.ExitB.Name = "ExitB";
			this.ExitB.Size = new System.Drawing.Size(45, 29);
			this.ExitB.TabIndex = 59;
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
			this.panel1.TabIndex = 57;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(297, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(208, 25);
			this.label12.TabIndex = 68;
			this.label12.Text = "Fill Box(es) Correctly";
			this.label12.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(722, 323);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(66, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// Form11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.QuarantineR);
			this.Controls.Add(this.DeceasedR);
			this.Controls.Add(this.PickIDBox);
			this.Controls.Add(this.SubmitB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitB);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form11";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form11";
			this.Load += new System.EventHandler(this.Form11_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton QuarantineR;
		private System.Windows.Forms.RadioButton DeceasedR;
		private System.Windows.Forms.TextBox PickIDBox;
		private System.Windows.Forms.Button SubmitB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ExitB;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label12;
	}
}