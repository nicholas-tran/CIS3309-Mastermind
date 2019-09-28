// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_Mastermind
{
    // Leaderboard Form shows the player the top 10 scores for each difficulty
    // If the player has won, they can enter their name into the leaderboard
    public partial class frmLeaderboard : Form
    {
        // Non-parameterized constructor
        public frmLeaderboard()
        {
            InitializeComponent();
        }

        //Attributes
        public bool win = false;
        public int winTurn = 0;
        public int winTime = 0;
        public string winDifficulty = "";

        // Initializing leaderboard
        LeaderboardClass leader = new LeaderboardClass();
        private void loadLeaderboard()
        {
            lblEasyName.Text = "";
            lblEasyTime.Text = "";
            lblEasyTurns.Text = "";
            lblMediumName.Text = "";
            lblMediumTime.Text = "";
            lblMediumTurns.Text = "";
            lblHardName.Text = "";
            lblHardTime.Text = "";
            lblHardTurns.Text = "";

            List<Player> temp = leader.returnEasyList();
            for (int i = 0; i < 10; i++)
            {
                lblEasyName.Text += temp.ElementAt(i).getName() + "\n";
                lblEasyTime.Text += temp.ElementAt(i).getTime() + "\n";
                lblEasyTurns.Text += temp.ElementAt(i).getTurn() + "\n";
            }
            temp = leader.returnMediumList();
            for (int i = 0; i < 10; i++)
            {
                lblMediumName.Text += temp.ElementAt(i).getName() + "\n";
                lblMediumTime.Text += temp.ElementAt(i).getTime() + "\n";
                lblMediumTurns.Text += temp.ElementAt(i).getTurn() + "\n";
            }
            temp = leader.returnHardList();
            for (int i = 0; i < 10; i++)
            {
                lblHardName.Text += temp.ElementAt(i).getName() + "\n";
                lblHardTime.Text += temp.ElementAt(i).getTime() + "\n";
                lblHardTurns.Text += temp.ElementAt(i).getTurn() + "\n";
            }
        }

        //Method to load leaderboard when player wins the game
        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            leader.initializeEntireList();
            loadLeaderboard();
            if (win == false)
            {
                pnlAddWinner.Visible = false;
            }
            else
                lblWinDifficulty.Text += winDifficulty;
            lblWinTime.Text += winTime;
            lblWinTurns.Text += winTurn;
        }

        // Button event handler to close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // OK Button event handler for user to submit their name to the leaderboard
        // Validation is also done here to make sure the user enters a valid name
        private void btnWinOk_Click(object sender, EventArgs e)
        {
            //leader.checkLeaderboard(txtWinName.Text, winDifficulty, winTurn, winTime);
            if (String.IsNullOrWhiteSpace(txtWinName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            leader.addLeaderboard(txtWinName.Text.ToUpper(), winDifficulty, winTurn, winTime);
            leader.writeLeaderboard();
            leader.initializeEntireList();
            loadLeaderboard();
            lblEasyName.ResetText();
            lblEasyTime.ResetText();
            lblEasyTurns.ResetText();
            lblHardName.ResetText();
            lblHardTime.ResetText();
            lblHardTurns.ResetText();
            loadLeaderboard();
            btnWinOk.Enabled = false;
            txtWinName.Enabled = false;
        }
    }
}
