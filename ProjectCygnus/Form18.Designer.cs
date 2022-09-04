namespace ProjectCygnus
{
	partial class Form18
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
			this.ExitB = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.PercribedL = new System.Windows.Forms.Label();
			this.Perscribed1L = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ExitB
			// 
			this.ExitB.Location = new System.Drawing.Point(603, 12);
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
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 322);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 41);
			this.panel1.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 26);
			this.label1.TabIndex = 19;
			this.label1.Text = "Doctor Prescribed:";
			// 
			// PercribedL
			// 
			this.PercribedL.AutoSize = true;
			this.PercribedL.Location = new System.Drawing.Point(14, 119);
			this.PercribedL.Name = "PercribedL";
			this.PercribedL.Size = new System.Drawing.Size(77, 17);
			this.PercribedL.TabIndex = 20;
			this.PercribedL.Text = "Percribed :";
			// 
			// Perscribed1L
			// 
			this.Perscribed1L.AutoSize = true;
			this.Perscribed1L.Location = new System.Drawing.Point(88, 119);
			this.Perscribed1L.Name = "Perscribed1L";
			this.Perscribed1L.Size = new System.Drawing.Size(147, 17);
			this.Perscribed1L.TabIndex = 21;
			this.Perscribed1L.Text = "Percribed Nothing Yet";
			// 
			// Form18
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(660, 363);
			this.Controls.Add(this.Perscribed1L);
			this.Controls.Add(this.PercribedL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitB);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form18";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form18";
			this.Load += new System.EventHandler(this.Form18_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label PercribedL;
		private System.Windows.Forms.Label Perscribed1L;
	}
}