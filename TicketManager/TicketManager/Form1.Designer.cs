namespace TicketManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTickets = new System.Windows.Forms.TextBox();
            this.btnValue = new System.Windows.Forms.Button();
            this.rbtKids = new System.Windows.Forms.RadioButton();
            this.rbtScholars = new System.Windows.Forms.RadioButton();
            this.rbtStudents = new System.Windows.Forms.RadioButton();
            this.lbValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CinemaCity";
            // 
            // txbTickets
            // 
            this.txbTickets.Location = new System.Drawing.Point(269, 123);
            this.txbTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTickets.Name = "txbTickets";
            this.txbTickets.Size = new System.Drawing.Size(121, 20);
            this.txbTickets.TabIndex = 1;
            // 
            // btnValue
            // 
            this.btnValue.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnValue.Location = new System.Drawing.Point(210, 221);
            this.btnValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(59, 31);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "Total";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // rbtKids
            // 
            this.rbtKids.AutoSize = true;
            this.rbtKids.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtKids.Location = new System.Drawing.Point(82, 119);
            this.rbtKids.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtKids.Name = "rbtKids";
            this.rbtKids.Size = new System.Drawing.Size(57, 23);
            this.rbtKids.TabIndex = 3;
            this.rbtKids.TabStop = true;
            this.rbtKids.Text = "Kids";
            this.rbtKids.UseVisualStyleBackColor = true;
            // 
            // rbtScholars
            // 
            this.rbtScholars.AutoSize = true;
            this.rbtScholars.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtScholars.Location = new System.Drawing.Point(82, 145);
            this.rbtScholars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtScholars.Name = "rbtScholars";
            this.rbtScholars.Size = new System.Drawing.Size(82, 23);
            this.rbtScholars.TabIndex = 4;
            this.rbtScholars.TabStop = true;
            this.rbtScholars.Text = "Scholars";
            this.rbtScholars.UseVisualStyleBackColor = true;
            // 
            // rbtStudents
            // 
            this.rbtStudents.AutoSize = true;
            this.rbtStudents.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtStudents.Location = new System.Drawing.Point(82, 172);
            this.rbtStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtStudents.Name = "rbtStudents";
            this.rbtStudents.Size = new System.Drawing.Size(85, 23);
            this.rbtStudents.TabIndex = 5;
            this.rbtStudents.TabStop = true;
            this.rbtStudents.Text = "Students";
            this.rbtStudents.UseVisualStyleBackColor = true;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.BackColor = System.Drawing.Color.White;
            this.lbValue.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbValue.Location = new System.Drawing.Point(281, 223);
            this.lbValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(0, 26);
            this.lbValue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tickets for :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many tickets do you want?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(315, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "лв.";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(413, 280);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 24);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(492, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.rbtStudents);
            this.Controls.Add(this.rbtScholars);
            this.Controls.Add(this.rbtKids);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.txbTickets);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TicketManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbTickets;
		private System.Windows.Forms.Button btnValue;
		private System.Windows.Forms.RadioButton rbtKids;
		private System.Windows.Forms.RadioButton rbtScholars;
		private System.Windows.Forms.RadioButton rbtStudents;
		private System.Windows.Forms.Label lbValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
	}
}

