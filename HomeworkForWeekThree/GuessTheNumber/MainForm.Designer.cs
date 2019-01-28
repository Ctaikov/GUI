namespace GuessTheNumber
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
            this.lbLevel = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.lbTries = new System.Windows.Forms.Label();
            this.lbGuess = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbTriesNum = new System.Windows.Forms.Label();
            this.pbThumbsUp = new System.Windows.Forms.PictureBox();
            this.pbUpDown = new System.Windows.Forms.PictureBox();
            this.btGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(41, 36);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(68, 13);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "Choose level";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "1-10",
            "1-50",
            "1-100",
            "1-1000"});
            this.cbLevel.Location = new System.Drawing.Point(34, 52);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 21);
            this.cbLevel.TabIndex = 1;
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(167, 50);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 2;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // lbTries
            // 
            this.lbTries.AutoSize = true;
            this.lbTries.Location = new System.Drawing.Point(41, 187);
            this.lbTries.Name = "lbTries";
            this.lbTries.Size = new System.Drawing.Size(78, 13);
            this.lbTries.TabIndex = 3;
            this.lbTries.Text = "Number of tries";
            // 
            // lbGuess
            // 
            this.lbGuess.AutoSize = true;
            this.lbGuess.Location = new System.Drawing.Point(21, 104);
            this.lbGuess.Name = "lbGuess";
            this.lbGuess.Size = new System.Drawing.Size(134, 13);
            this.lbGuess.TabIndex = 4;
            this.lbGuess.Text = "Guess the random number.";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(34, 120);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 5;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // lbTriesNum
            // 
            this.lbTriesNum.AutoSize = true;
            this.lbTriesNum.Location = new System.Drawing.Point(73, 200);
            this.lbTriesNum.Name = "lbTriesNum";
            this.lbTriesNum.Size = new System.Drawing.Size(13, 13);
            this.lbTriesNum.TabIndex = 6;
            this.lbTriesNum.Text = "0";
            this.lbTriesNum.Click += new System.EventHandler(this.lbTriesNum_Click);
            // 
            // pbThumbsUp
            // 
            this.pbThumbsUp.InitialImage = null;
            this.pbThumbsUp.Location = new System.Drawing.Point(248, 137);
            this.pbThumbsUp.Name = "pbThumbsUp";
            this.pbThumbsUp.Size = new System.Drawing.Size(81, 76);
            this.pbThumbsUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumbsUp.TabIndex = 8;
            this.pbThumbsUp.TabStop = false;
            // 
            // pbUpDown
            // 
            this.pbUpDown.InitialImage = null;
            this.pbUpDown.Location = new System.Drawing.Point(163, 137);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(79, 76);
            this.pbUpDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpDown.TabIndex = 7;
            this.pbUpDown.TabStop = false;
            // 
            // btGuess
            // 
            this.btGuess.Location = new System.Drawing.Point(34, 146);
            this.btGuess.Name = "btGuess";
            this.btGuess.Size = new System.Drawing.Size(95, 21);
            this.btGuess.TabIndex = 9;
            this.btGuess.Text = "Guess";
            this.btGuess.UseVisualStyleBackColor = true;
            this.btGuess.Click += new System.EventHandler(this.btGuess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 260);
            this.Controls.Add(this.btGuess);
            this.Controls.Add(this.pbThumbsUp);
            this.Controls.Add(this.pbUpDown);
            this.Controls.Add(this.lbTriesNum);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lbGuess);
            this.Controls.Add(this.lbTries);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lbLevel);
            this.Name = "MainForm";
            this.Text = "GuessTheNumber";
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Label lbTries;
        private System.Windows.Forms.Label lbGuess;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbTriesNum;
        private System.Windows.Forms.PictureBox pbUpDown;
        private System.Windows.Forms.PictureBox pbThumbsUp;
        private System.Windows.Forms.Button btGuess;
    }
}

