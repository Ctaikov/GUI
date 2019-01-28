namespace Rock_Scissors_Paper
{
    partial class MainForm
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
            this.lbEnterName = new System.Windows.Forms.Label();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.btStartGame = new System.Windows.Forms.Button();
            this.lbYourName = new System.Windows.Forms.Label();
            this.lbComputer = new System.Windows.Forms.Label();
            this.lbChoose = new System.Windows.Forms.Label();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lbPlayerScore = new System.Windows.Forms.Label();
            this.lbPunc = new System.Windows.Forms.Label();
            this.lbComputerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterName
            // 
            this.lbEnterName.AutoSize = true;
            this.lbEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnterName.Location = new System.Drawing.Point(130, 9);
            this.lbEnterName.Name = "lbEnterName";
            this.lbEnterName.Size = new System.Drawing.Size(171, 24);
            this.lbEnterName.TabIndex = 0;
            this.lbEnterName.Text = "Enter your name:";
            // 
            // tbEnterName
            // 
            this.tbEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnterName.Location = new System.Drawing.Point(307, 7);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(178, 26);
            this.tbEnterName.TabIndex = 1;
            // 
            // btStartGame
            // 
            this.btStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStartGame.Location = new System.Drawing.Point(221, 39);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(180, 29);
            this.btStartGame.TabIndex = 2;
            this.btStartGame.Text = "Start the game!";
            this.btStartGame.UseVisualStyleBackColor = true;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // lbYourName
            // 
            this.lbYourName.AutoSize = true;
            this.lbYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYourName.Location = new System.Drawing.Point(131, 92);
            this.lbYourName.Name = "lbYourName";
            this.lbYourName.Size = new System.Drawing.Size(53, 16);
            this.lbYourName.TabIndex = 3;
            this.lbYourName.Text = "Player";
            // 
            // lbComputer
            // 
            this.lbComputer.AutoSize = true;
            this.lbComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputer.Location = new System.Drawing.Point(411, 92);
            this.lbComputer.Name = "lbComputer";
            this.lbComputer.Size = new System.Drawing.Size(74, 16);
            this.lbComputer.TabIndex = 4;
            this.lbComputer.Text = "Computer";
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChoose.Location = new System.Drawing.Point(176, 288);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(256, 20);
            this.lbChoose.TabIndex = 7;
            this.lbChoose.Text = "Choose rock, paper or scissors";
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::Rock_Scissors_Paper.Properties.Resources.scissors_11523889569lus03yfph1;
            this.pbScissors.InitialImage = global::Rock_Scissors_Paper.Properties.Resources.scissors_11523889569lus03yfph1;
            this.pbScissors.Location = new System.Drawing.Point(434, 323);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(140, 106);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScissors.TabIndex = 10;
            this.pbScissors.TabStop = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click);
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::Rock_Scissors_Paper.Properties.Resources._580b585b2edbce24c47b245f;
            this.pbPaper.InitialImage = global::Rock_Scissors_Paper.Properties.Resources._580b585b2edbce24c47b245f;
            this.pbPaper.Location = new System.Drawing.Point(259, 323);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(142, 106);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 9;
            this.pbPaper.TabStop = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click);
            // 
            // pbRock
            // 
            this.pbRock.Image = global::Rock_Scissors_Paper.Properties.Resources.stone_PNG13545;
            this.pbRock.InitialImage = global::Rock_Scissors_Paper.Properties.Resources.stone_PNG13545;
            this.pbRock.Location = new System.Drawing.Point(80, 323);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(151, 106);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRock.TabIndex = 8;
            this.pbRock.TabStop = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click);
            // 
            // pbComputer
            // 
            this.pbComputer.InitialImage = null;
            this.pbComputer.Location = new System.Drawing.Point(368, 125);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(166, 115);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputer.TabIndex = 6;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.InitialImage = null;
            this.pbPlayer.Location = new System.Drawing.Point(80, 125);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(163, 115);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 5;
            this.pbPlayer.TabStop = false;
            // 
            // lbPlayerScore
            // 
            this.lbPlayerScore.AutoSize = true;
            this.lbPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayerScore.Location = new System.Drawing.Point(270, 247);
            this.lbPlayerScore.Name = "lbPlayerScore";
            this.lbPlayerScore.Size = new System.Drawing.Size(19, 20);
            this.lbPlayerScore.TabIndex = 11;
            this.lbPlayerScore.Text = "0";
            // 
            // lbPunc
            // 
            this.lbPunc.AutoSize = true;
            this.lbPunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPunc.Location = new System.Drawing.Point(293, 247);
            this.lbPunc.Name = "lbPunc";
            this.lbPunc.Size = new System.Drawing.Size(14, 20);
            this.lbPunc.TabIndex = 12;
            this.lbPunc.Text = ":";
            // 
            // lbComputerScore
            // 
            this.lbComputerScore.AutoSize = true;
            this.lbComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputerScore.Location = new System.Drawing.Point(313, 247);
            this.lbComputerScore.Name = "lbComputerScore";
            this.lbComputerScore.Size = new System.Drawing.Size(19, 20);
            this.lbComputerScore.TabIndex = 13;
            this.lbComputerScore.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.lbComputerScore);
            this.Controls.Add(this.lbPunc);
            this.Controls.Add(this.lbPlayerScore);
            this.Controls.Add(this.pbScissors);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbRock);
            this.Controls.Add(this.lbChoose);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lbComputer);
            this.Controls.Add(this.lbYourName);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.tbEnterName);
            this.Controls.Add(this.lbEnterName);
            this.Name = "MainForm";
            this.Text = "Rock-Scissors-Paper";
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterName;
        private System.Windows.Forms.TextBox tbEnterName;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Label lbYourName;
        private System.Windows.Forms.Label lbComputer;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label lbChoose;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.Label lbPlayerScore;
        private System.Windows.Forms.Label lbPunc;
        private System.Windows.Forms.Label lbComputerScore;
    }
}

