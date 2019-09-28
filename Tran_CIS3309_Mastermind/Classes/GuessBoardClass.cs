// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_Mastermind
{
    // GuessBoardClass gets guesses from the form
    // Stores guesses into hiddenGuessArray of ints
    // Also returns hiddenGuessAray

    class GuessBoardClass
    {
        //Attributes
        int[] hiddenGuessArray = new int[4];

        // Method to set guesses into hiddenGuessArray
        public void setGuess(int a, int b, int c, int d)
        {
            hiddenGuessArray[0] = a;
            hiddenGuessArray[1] = b;
            hiddenGuessArray[2] = c;
            hiddenGuessArray[3] = d;

        }

        // Method to return the hiddenGuessArray
        public int[] returnGuessArray()
        {
            return hiddenGuessArray;
        }

    }
}
