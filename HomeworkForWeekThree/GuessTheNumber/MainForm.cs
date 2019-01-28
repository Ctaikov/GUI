using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class MainForm : Form
    {
        Random rand = new Random();
        int tries = 0;
        int rndNumber;
        string level;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            
            level = cbLevel.Text;
            if (level == "1-10")
            {
                rndNumber = rand.Next(1, 11);
            }
            else if (level == "1-50")
            {
                rndNumber = rand.Next(1, 51);
            }
            else if (level == "1-100")
            {
                rndNumber = rand.Next(1, 101);
            }
            else if (level == "1-1000")
            {
                rndNumber = rand.Next(1, 1001);
            };
            btPlay.Enabled = false;
        }
        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbTriesNum_Click(object sender, EventArgs e)
        {

        }
        private void Playing(int rndNumber)
        {
            if (int.Parse(tbNumber.Text) > rndNumber)
            {
                pbUpDown.Image = GuessTheNumber.Properties.Resources.Red_Arrow_Down;
            }
            else
            {
                pbUpDown.Image = GuessTheNumber.Properties.Resources.Red_Arrow_Up;
            }
            if (int.Parse(tbNumber.Text) == rndNumber)
            {
                pbThumbsUp.Image = GuessTheNumber.Properties.Resources.Thumbs_Up;
                pbUpDown.Image = null;
                btGuess.Enabled = false;
            }
            if (tries == 10)
            {
                pbThumbsUp.Image = GuessTheNumber.Properties.Resources.Thumbs_Down;
                pbUpDown.Image = null;

            }
            else if(int.Parse(tbNumber.Text)!=rndNumber)
            {
                tries++;
                lbTriesNum.Text = Convert.ToString(tries);
            }
        }
        private void btGuess_Click(object sender, EventArgs e)
        {
            Playing(rndNumber);
            tbNumber.Focus();
        }
    }
}
