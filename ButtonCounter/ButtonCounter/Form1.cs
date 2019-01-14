using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
	public partial class Form1 : Form
	{
		int counter = 0;
		
		public Form1()
		{
			InitializeComponent();
			lbcounter.Text = " 0 ";
		}

		private void btncounter_Click(object sender, EventArgs e)
		{
			
			counter++;
			lbcounter.Text = counter.ToString();
			switch (counter)
			{
				case 5:
					this.BackColor = Color.Red; break;
				case 10:
					this.BackColor = Color.BlueViolet; break;
				case 15:
					this.BackColor = Color.LightGoldenrodYellow; break;
				default:
					this.BackColor = Color.White; break;
			}
		
		}

		private void btnreset_Click(object sender, EventArgs e)
		{
			lbcounter.Text = "0 ";
			counter = 0;
			
		
		}

		
	}
}
