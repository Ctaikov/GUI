using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Paper
{
    public partial class MainForm : Form
    {
        Random pcRandom = new Random();
        int playerChoice = 0;
        int computerChoice = 0;
        int playerWin = 0;
        int computerWin = 0;
        public MainForm()
        {
            InitializeComponent();
            pbRock.Enabled = false;
            pbPaper.Enabled = false;
            pbScissors.Enabled = false;
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            tbEnterName.Focus();
            lbYourName.Text = tbEnterName.Text;
            btStartGame.Enabled = false;
            tbEnterName.Enabled = false;
            pbRock.Enabled = true;
            pbPaper.Enabled = true;
            pbScissors.Enabled = true;
            
        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = pbRock.Image;
            computerChoice = pcRandom.Next(1, 4);
            pcChoosing(computerChoice);
            if(pbPlayer.Image == pbRock.Image && pbComputer.Image == pbPaper.Image)
            {
                computerWin++;
                lbComputerScore.Text = Convert.ToString(computerWin);
                MessageBox.Show($"The winner of this round is {lbComputer.Text}");
            }
            else if (pbPlayer.Image==pbRock.Image && pbComputer.Image==pbScissors.Image)
            {
                playerWin++;
                lbPlayerScore.Text = Convert.ToString(playerWin);
                MessageBox.Show($"The winner of this round is {lbYourName.Text}");
            }
            else if (pbPlayer.Image == pbRock.Image && pbComputer.Image == pbRock.Image)
            {
                MessageBox.Show("No change in the score.", "It's a draw!", MessageBoxButtons.OK);
            }
            if (playerWin == 10)
            {
                MessageBox.Show($"{lbYourName.Text} wins the game.");
                this.Close();
            }
            else if (computerWin == 10)
            {
                MessageBox.Show($"{lbComputer.Text} wins the game.");
                this.Close();
            }
        }
        private void pbPaper_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = pbPaper.Image;
            computerChoice = pcRandom.Next(1, 4);
            pcChoosing(computerChoice);
            if (pbPlayer.Image == pbPaper.Image && pbComputer.Image == pbScissors.Image)
            {
                computerWin++;
                lbComputerScore.Text = Convert.ToString(computerWin);
                MessageBox.Show($"The winner of this round is{lbComputer.Text}","",MessageBoxButtons.OK);
            }
            else if (pbPlayer.Image == pbPaper.Image && pbComputer.Image == pbRock.Image)
            {
                playerWin++;
                lbPlayerScore.Text = Convert.ToString(playerWin);
                MessageBox.Show($"The winner of this round is{lbYourName.Text}","",MessageBoxButtons.OK);
            }
            else if (pbPlayer.Image == pbPaper.Image && pbComputer.Image == pbPaper.Image)
            {
                MessageBox.Show("No change in the score.", "It's a draw!", MessageBoxButtons.OK);
            }
            if (playerWin == 10)
            {
                MessageBox.Show($"{lbYourName.Text} wins the game.");
                this.Close();
            }
            else if (computerWin == 10)
            {
                MessageBox.Show($"{lbComputer.Text} wins the game.");
                this.Close();
            }
        }
        private void pbScissors_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = pbScissors.Image;
            computerChoice = pcRandom.Next(1, 4);
            pcChoosing(computerChoice);
            if (pbPlayer.Image == pbScissors.Image && pbComputer.Image == pbRock.Image)
            {
                computerWin++;
                lbComputerScore.Text = Convert.ToString(computerWin);
                MessageBox.Show($"The winner of this round is{lbComputer.Text}","",MessageBoxButtons.OK);
            }
            else if (pbPlayer.Image == pbScissors.Image && pbComputer.Image == pbPaper.Image)
            {
                playerWin++;
                lbPlayerScore.Text = Convert.ToString(playerWin);
                MessageBox.Show($"The winner of this round is{lbYourName.Text}","",MessageBoxButtons.OK);
            }
            else if(pbPlayer.Image==pbScissors.Image && pbComputer.Image==pbScissors.Image)
            {
                MessageBox.Show("No change in the score.", "It's a draw!",MessageBoxButtons.OK);
            }
            if (playerWin == 10)
            {
                MessageBox.Show($"{lbYourName.Text} wins the game.");
                this.Close();
            }
            else if (computerWin == 10)
            {
                MessageBox.Show($"{lbComputer.Text} wins the game.");
                this.Close();
            }
        }
        private void pcChoosing(int computerChoice)
        {
            if (computerChoice == 1)
            {
                pbComputer.Image = pbRock.Image;
            }
            else if (computerChoice == 2)
            {
                pbComputer.Image = pbPaper.Image;
            }
            else
            {
                pbComputer.Image = pbScissors.Image;
            }
        }
    }
}
