// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 


namespace Tran_CIS3309_Mastermind
{
    partial class frmMastermind
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMastermind));
            this.pnlGuess = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.hintList = new System.Windows.Forms.ImageList(this.components);
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.cbxDifficulty = new System.Windows.Forms.ComboBox();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.colorList = new System.Windows.Forms.ImageList(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlGuess
            // 
            this.pnlGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuess.Location = new System.Drawing.Point(15, 47);
            this.pnlGuess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGuess.Name = "pnlGuess";
            this.pnlGuess.Size = new System.Drawing.Size(207, 576);
            this.pnlGuess.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Enabled = false;
            this.btnOK.ImageKey = "(none)";
            this.btnOK.Location = new System.Drawing.Point(235, 641);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlHint
            // 
            this.pnlHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHint.Location = new System.Drawing.Point(235, 47);
            this.pnlHint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(207, 576);
            this.pnlHint.TabIndex = 2;
            // 
            // hintList
            // 
            this.hintList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hintList.ImageStream")));
            this.hintList.TransparentColor = System.Drawing.Color.Transparent;
            this.hintList.Images.SetKeyName(0, "Clear.png");
            this.hintList.Images.SetKeyName(1, "White.png");
            this.hintList.Images.SetKeyName(2, "Black.png");
            // 
            // pnlSolution
            // 
            this.pnlSolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolution.Location = new System.Drawing.Point(15, 641);
            this.pnlSolution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(207, 48);
            this.pnlSolution.TabIndex = 3;
            // 
            // cbxDifficulty
            // 
            this.cbxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDifficulty.FormattingEnabled = true;
            this.cbxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbxDifficulty.Location = new System.Drawing.Point(135, 7);
            this.cbxDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDifficulty.Name = "cbxDifficulty";
            this.cbxDifficulty.Size = new System.Drawing.Size(87, 24);
            this.cbxDifficulty.TabIndex = 4;
            this.cbxDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbxDifficulty_SelectedIndexChanged);
            this.cbxDifficulty.SelectionChangeCommitted += new System.EventHandler(this.cbxDifficulty_SelectionChangeCommitted);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Location = new System.Drawing.Point(343, 641);
            this.btnLeaderboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(100, 28);
            this.btnLeaderboard.TabIndex = 5;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(16, 11);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(108, 17);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "Select Difficulty:";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGuess.Location = new System.Drawing.Point(20, 39);
            this.lblGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(89, 17);
            this.lblGuess.TabIndex = 7;
            this.lblGuess.Text = "Guess Panel";
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(235, 677);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(100, 28);
            this.btnRetry.TabIndex = 8;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(343, 677);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Location = new System.Drawing.Point(240, 39);
            this.lblHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(73, 17);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "Hint Panel";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSolution.Location = new System.Drawing.Point(20, 633);
            this.lblSolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(99, 17);
            this.lblSolution.TabIndex = 10;
            this.lblSolution.Text = "Solution Panel";
            // 
            // colorList
            // 
            this.colorList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("colorList.ImageStream")));
            this.colorList.TransparentColor = System.Drawing.Color.Transparent;
            this.colorList.Images.SetKeyName(0, "Red.png");
            this.colorList.Images.SetKeyName(1, "Blue.png");
            this.colorList.Images.SetKeyName(2, "Green.png");
            this.colorList.Images.SetKeyName(3, "Yellow.png");
            this.colorList.Images.SetKeyName(4, "Purple.png");
            this.colorList.Images.SetKeyName(5, "pink.png");
            this.colorList.Images.SetKeyName(6, "Teal.png");
            this.colorList.Images.SetKeyName(7, "Orange.png");
            this.colorList.Images.SetKeyName(8, "LightGreen.png");
            this.colorList.Images.SetKeyName(9, "DarkPink.png");
            this.colorList.Images.SetKeyName(10, "LightBlue.png");
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(240, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 17);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time: 0";
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(343, 8);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(75, 23);
            this.btnRules.TabIndex = 12;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // frmMastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(463, 710);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.cbxDifficulty);
            this.Controls.Add(this.pnlHint);
            this.Controls.Add(this.pnlSolution);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlGuess);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMastermind";
            this.Text = "Mastermind Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGuess;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.ImageList hintList;
        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.ComboBox cbxDifficulty;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.ImageList colorList;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRules;
    }
}

