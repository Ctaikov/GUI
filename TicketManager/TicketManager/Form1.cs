using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
	public partial class Form1 : Form
	{
		int kids = 3, scholar=4, student=5, numberOftickets, total;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
		{
			InitializeComponent();
		}
		private void btnValue_Click(object sender, EventArgs e)
		{
			numberOftickets = int.Parse(txbTickets.Text);
			if (rbtKids.Checked)
			{
				total = numberOftickets * kids;
				lbValue.Text = total.ToString();
				rbtKids.Checked = false;
				txbTickets.Text = "";

			}
			else if (rbtScholars.Checked)
			{
				total = numberOftickets * scholar;
				lbValue.Text = total.ToString();
				rbtScholars.Checked = false;
				txbTickets.Text = "";
			}
			else if (rbtStudents.Checked)
			{
				total = numberOftickets * student;
				lbValue.Text = total.ToString();
				rbtStudents.Checked = false;
				txbTickets.Text = "";
			}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
