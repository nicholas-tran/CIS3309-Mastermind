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
    public partial class frmMastermind : Form
    {
        public frmMastermind()
        {
            InitializeComponent();

        }
        // Attributes
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        bool clickFlag1 = false;
        bool clickFlag2 = false;
        bool clickFlag3 = false;
        bool clickFlag4 = false;
        int seconds = 0;
        int numColors = 10;
        int turns = 0;
        int BoardRow;
        int BoardCol;
        SolutionGeneratorClass solution = new SolutionGeneratorClass();
        Button[,] guessButtons;
        Button[,] hintButtons;
        Button[,] solutionButtons;

        // Function to reset the counters for the buttons
        public void resetCounters()
        {
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            counter4 = 0;
        }

        // Function to reset 
        public void resetClickFlags()
        {
            clickFlag1 = false;
            clickFlag2 = false;
            clickFlag3 = false;
            clickFlag4 = false;
        }

        // Creates the guess Card for Play
        public void createGuessCard(int BoardRow, int BoardCol)
        {
            Size size = new Size(39, 39);
            Point loc = new Point(0, 0);
            int topMargin = 0;
            guessButtons = new Button[BoardRow, BoardCol];

            for (int row = 0; row < BoardRow; row++)
            {
                loc.Y = topMargin + row * (size.Height);
                int extraLeftPadding = 0;
                for (int col = 0; col < BoardCol; col++)
                {
                    guessButtons[row, col] = new Button();
                    guessButtons[row, col].Location = new Point(extraLeftPadding + col * (size.Width), loc.Y);
                    guessButtons[row, col].Size = size;
                    guessButtons[row, col].Enabled = false;
                    guessButtons[row, col].Name = "btn" + row.ToString() + col.ToString();
                    guessButtons[row, col].ImageList = colorList;
                    guessButtons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    // Associates the same event handler with each of the buttons generated
                    if (col == 0)
                    {
                        guessButtons[row, col].Click += new EventHandler(btnGuess1Button_Click);
                    }
                    if (col == 1)
                    {
                        guessButtons[row, col].Click += new EventHandler(btnGuess2Button_Click);
                    }
                    if (col == 2)
                    {
                        guessButtons[row, col].Click += new EventHandler(btnGuess3Button_Click);
                    }
                    if (col == 3)
                    {
                        guessButtons[row, col].Click += new EventHandler(btnGuess4Button_Click);
                    }
                    // Add button to the form
                    pnlGuess.Controls.Add(guessButtons[row, col]);

                } // end for col
                  // One row now complete
            } // end for row
        } // end createBoard

        // Methods that creates the hint card 
        public void createHintCard(int BoardRow, int BoardCol)
        {
            Size size = new Size(39, 39);
            Point loc = new Point(0, 0);
            int topMargin = 0;
            hintButtons = new Button[BoardRow, BoardCol];

            for (int row = 0; row < BoardRow; row++)
            {
                loc.Y = topMargin + row * (size.Height);
                int extraLeftPadding = 0;
                for (int col = 0; col < BoardCol; col++)
                {
                    hintButtons[row, col] = new Button();
                    hintButtons[row, col].Location = new Point(extraLeftPadding + col * (size.Width), loc.Y);
                    hintButtons[row, col].Size = size;
                    hintButtons[row, col].Enabled = false;
                    hintButtons[row, col].Name = "btn" + row.ToString() + col.ToString();
                    hintButtons[row, col].ImageList = hintList;
                    hintButtons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    hintButtons[row, col].BackgroundImage = hintList.Images[0];
                    // Add button to the form
                    pnlHint.Controls.Add(hintButtons[row, col]);

                } // end for col
                  // One row now complete
            } // end for row
        } // end createBoard

        // Methods that creates the solution card
        public void createSolutionCard()
        {
            BoardRow = 1;
            BoardCol = 4;
            Size size = new Size(39, 39);
            Point loc = new Point(0, 0);
            int topMargin = 0;
            solutionButtons = new Button[BoardRow, BoardCol];
            int[] solutionArray = solution.returnSolutionArray();
            for (int row = 0; row < BoardRow; row++)
            {
                loc.Y = topMargin + row * (size.Height);
                int extraLeftPadding = 0;
                for (int col = 0; col < BoardCol; col++)
                {
                    solutionButtons[row, col] = new Button();
                    solutionButtons[row, col].Location = new Point(extraLeftPadding + col * (size.Width), loc.Y);
                    solutionButtons[row, col].Size = size;
                    solutionButtons[row, col].Enabled = false;
                    solutionButtons[row, col].Name = "btn" + row.ToString() + col.ToString();
                    solutionButtons[row, col].ImageList = colorList;
                    solutionButtons[row, col].BackgroundImage = colorList.Images[solutionArray[col]];
                    solutionButtons[row, col].BackgroundImageLayout = ImageLayout.Stretch;

                    // Add button to the form
                    pnlSolution.Controls.Add(solutionButtons[row, col]);

                } // end for col
                  // One row now complete
            } // end for row
        } // end createBoard

        // Button event handler for the guess button in the first column
        // Sets the clicked boolean flag to true 
        // Increases the counter for the first column 
        public void btnGuess1Button_Click(object sender, EventArgs e)
        {
            clickFlag1 = true;
            counter1 = ((counter1 + 1) % numColors);
            ((Button)sender).BackgroundImage = colorList.Images[counter1];
        }

        // Button event handler for the guess button in the second column
        // Sets the clicked boolean flag to true 
        // Increases the counter for the second column 
        public void btnGuess2Button_Click(object sender, EventArgs e)
        {
            clickFlag2 = true;
            counter2 = ((counter2 + 1) % numColors);
            ((Button)sender).BackgroundImage = colorList.Images[counter2];
        }

        // Button event handler for the guess button in the third column
        // Sets the clicked boolean flag to true 
        // Increases the counter for the third column 
        public void btnGuess3Button_Click(object sender, EventArgs e)
        {
            clickFlag3 = true;
            counter3 = ((counter3 + 1) % numColors);
            ((Button)sender).BackgroundImage = colorList.Images[counter3];
        }

        // Button event handler for the guess button in the forth column
        // Sets the clicked boolean flag to true 
        // Increases the counter for the forth column 
        public void btnGuess4Button_Click(object sender, EventArgs e)
        {
            clickFlag4 = true;
            counter4 = ((counter4 + 1) % numColors);
            ((Button)sender).BackgroundImage = colorList.Images[counter4];
        }

        // Event handler for the difficult combo box
        // Leads the solution and guess form based on user selection
        private void cbxDifficulty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxDifficulty.SelectedItem.ToString().Equals("Easy"))
            {
                btnOK.Enabled = true;
                numColors = 6;
                turns = 12;
                createGuessCard(12, 4);
                createHintCard(12, 4);
                pnlGuess.Size = new Size(156, 468);
                pnlHint.Size = new Size(156, 468);
                solution.generateEasySolution();
                lblGuess.BringToFront();
                createSolutionCard();
                for (int i = 0; i < 4; i++)
                {
                    guessButtons[0, i].Enabled = true;
                }
                pnlSolution.Visible = false;
                //
            }
            else if (cbxDifficulty.SelectedItem.ToString().Equals("Medium"))
            {
                btnOK.Enabled = true;
                numColors = 8;
                turns = 10;
                createGuessCard(10, 4);
                createHintCard(10, 4);
                pnlGuess.Size = new Size(156, 390);
                pnlHint.Size = new Size(156, 390);
                solution.generateMediumSolution();
                lblGuess.BringToFront();
                createSolutionCard();
                //Resize form to be smaller
                this.Size = new Size(360, 535);
                //Change solution panel location
                pnlSolution.Location = new Point(11, 440);
                //Changing label location
                lblSolution.Location = new Point(20, 430);
                //Changing button location
                btnOK.Location = new Point(178, 435);
                btnRetry.Location = new Point(178, 461);
                btnLeaderboard.Location = new Point(255, 435);
                btnExit.Location = new Point(255, 461);
                for (int i = 0; i < 4; i++)
                {
                    guessButtons[0, i].Enabled = true;
                }
                pnlSolution.Visible = false;
               
            }
            else if (cbxDifficulty.SelectedItem.ToString().Equals("Hard"))
            {
                btnOK.Enabled = true;
                numColors = 10;
                turns = 8;
                createGuessCard(8, 4);
                createHintCard(8, 4);
                pnlGuess.Size = new Size(156, 312);
                pnlHint.Size = new Size(156, 312);
                solution.generateHardSolution();
                lblGuess.BringToFront();
                createSolutionCard();
                //Resize form to be smaller
                this.Size = new Size(360, 450);
                //Change solution panel location
                pnlSolution.Location = new Point(11, 360);
                //Changing label location
                lblSolution.Location = new Point(20, 350);
                //Changing button location
                btnOK.Location = new Point(178, 355);
                btnRetry.Location = new Point(178, 380);
                btnLeaderboard.Location = new Point(255, 355);
                btnExit.Location = new Point(255, 380);
                for (int i = 0; i < 4; i++)
                {
                    guessButtons[0, i].Enabled = true;
                }
                pnlSolution.Visible = false;
            }
        }

        // Button eventer handler to close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ok button event handler
        // Checks to makes sure all the button has been clicked atleast once
        // Does the comparison from the player guess with the solution
        // Resets the clicked flags boolean for next round
        // Checks if the player won or not
        // Disables butons if the user wins
        // Loads up the leaderboard form when the user wins
        private void btnOK_Click(object sender, EventArgs e)
        {
            cbxDifficulty.Enabled = false;
            int count = solution.returnAttempts();
            solution.guess.setGuess(counter1++, counter2++, counter3++, counter4++);
            if (clickFlag1 == false || clickFlag2 == false || clickFlag3 == false || clickFlag4 == false)
            {
                MessageBox.Show("There is a missing color for your guess.");
                return;
            }
            else if (!solution.processRound(solution.returnSolutionArray()))
            {
                resetCounters();
                int[] temp = solution.hints.returnHints();
                for (int i = 0; i < 4; i++)
                {
                    hintButtons[solution.returnAttempts() - 1, i].BackgroundImage = hintList.Images[temp[i]];
                    guessButtons[solution.returnAttempts() - 1, i].Enabled = false;
                    if (solution.returnAttempts() < turns)
                    {
                        guessButtons[solution.returnAttempts(), i].Enabled = true;
                    }
                }
                resetClickFlags();
                if (solution.returnAttempts().Equals(turns))
                {
                    btnOK.Enabled = false;
                    tmrClock.Enabled = false;
                    pnlSolution.Visible = true;
                    MessageBox.Show("Game Over");
                }
            }
            else
            {
                int[] temp = solution.hints.returnHints();
                for (int i = 0; i < 4; i++)
                {
                    hintButtons[solution.returnAttempts(), i].BackgroundImage = hintList.Images[temp[i]];
                    if (solution.returnAttempts() != 0)
                    {
                        guessButtons[solution.returnAttempts() - 1, i].Enabled = false;
                    }
                    else
                        guessButtons[solution.returnAttempts(), i].Enabled = false;
                }
                pnlSolution.Visible = true;
                tmrClock.Enabled = false;
                btnOK.Enabled = false;
                frmLeaderboard newForm = new frmLeaderboard();
                newForm.win = solution.returnWin();
                newForm.winTime = seconds;
                if (solution.returnAttempts() == 0)
                {
                    newForm.winTurn = 1;
                }
                else
                {
                    newForm.winTurn = solution.returnAttempts()+1;
                }
                newForm.winDifficulty = cbxDifficulty.SelectedItem.ToString();
                newForm.Show();
                MessageBox.Show("You win");
            }
        }

        // Button event handler for the retry button.
        // Resets the number of attempts, counters, time
        // Clears the controls on the form and initialize components again.
        private void btnRetry_Click(object sender, EventArgs e)
        {
            solution.resetAttempts();
            resetCounters();
            tmrClock.Enabled = false;
            seconds = 0;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        // Leaderboard button event handler that loads the leaderboard form
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            int[] solutionArray = solution.returnSolutionArray();
            frmLeaderboard temp = new frmLeaderboard();
            temp.Show();
        }

        // Combo box that allows player to choose their difficulty
        // Disabled after the user picks one
        private void cbxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDifficulty.Enabled = false;
            tmrClock.Enabled = true;
        }

        // Event handler for the clock
        // Every 1000ms it increases the variable seconds by 1
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = "Time: " + seconds;
        }

        // Event handler for the rules buttons
        // Explains the rules on how the game is played
        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rules to the game: \n 1. Player selects difficulty\n 2. Player will guess the color combination of 4 colors\n 3. Guesses are made by clicking on the row of buttons on the left side.\n 4. Press the OK button to submit your guess.\n 5. Hints will be given on the right side.\n 6. Black represents a correct color and its position is also correct.\n 7. White represents a right color but in the wrong position.\n 8. Keep making guesses until you get all 4 colors or run out of turns.");
        }
    }
}