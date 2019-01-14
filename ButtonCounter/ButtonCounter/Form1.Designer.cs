namespace ButtonCounter
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
			this.btncounter = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.lbcounter = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btncounter
			// 
			this.btncounter.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btncounter.ForeColor = System.Drawing.Color.Black;
			this.btncounter.Location = new System.Drawing.Point(83, 117);
			this.btncounter.Name = "btncounter";
			this.btncounter.Size = new System.Drawing.Size(102, 62);
			this.btncounter.TabIndex = 0;
			this.btncounter.Text = "COUNT";
			this.btncounter.UseVisualStyleBackColor = false;
			this.btncounter.Click += new System.EventHandler(this.btncounter_Click);
			// 
			// btnreset
			// 
			this.btnreset.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnreset.Location = new System.Drawing.Point(304, 117);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(103, 62);
			this.btnreset.TabIndex = 1;
			this.btnreset.Text = "RESET";
			this.btnreset.UseVisualStyleBackColor = false;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			// 
			// lbcounter
			// 
			this.lbcounter.AutoSize = true;
			this.lbcounter.Location = new System.Drawing.Point(223, 140);
			this.lbcounter.Name = "lbcounter";
			this.lbcounter.Size = new System.Drawing.Size(0, 17);
			this.lbcounter.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(155, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 39);
			this.label1.TabIndex = 3;
			this.label1.Text = "Counter";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 255);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbcounter);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btncounter);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btncounter;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Label lbcounter;
		private System.Windows.Forms.Label label1;
	}
}

