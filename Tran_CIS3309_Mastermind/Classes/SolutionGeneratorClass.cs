// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_CIS3309_Mastermind
{
    // The Solution Generator class creates the solution for the user to guess
    // The solution is genertated based on the difficulty the user selects
    // The hints are also done in the class to show the user black and white pins
    // Finally the rounds are processed to see if the winner has won the game or not
    class SolutionGeneratorClass
    {
        // Attributes
        Random rng = new Random();
        public HintGeneratorClass hints = new HintGeneratorClass();
        public GuessBoardClass guess = new GuessBoardClass();
        int[] hiddenSolutionArray = new int[4];
        int attempt = 0;
        bool win = false;

        // Non-parametrized constructor for the solution generator
        public SolutionGeneratorClass()
        {
            hiddenSolutionArray = new int[4];
        }

        // Function that returns the hidden solution array of ints
        public int[] returnSolutionArray()
        {
            return hiddenSolutionArray;
        }

        // Generates the solution for easy mode
        // Random numbers that ranges from 1 to 6 is placed in the solution array
        public void generateEasySolution()
        {
            int temp;
            for (int i = 0; i < hiddenSolutionArray.Length; i++)
            {
                temp = rng.Next(0, 6);
                for (int j = 0; j < hiddenSolutionArray.Length; j++)
                {
                    if (temp == hiddenSolutionArray[j])
                    {
                        temp = rng.Next(0, 6);
                    }
                } 
                hiddenSolutionArray[i] = temp;
            }
        }

        // Generates the solution for medium mode
        // Random numbers that ranges from 1 to 8 is placed in the solution array
        public void generateMediumSolution()
        {
            hiddenSolutionArray = new int[4];
            int temp;
            for (int i = 0; i < hiddenSolutionArray.Length; i++)
            {
                temp = rng.Next(0, 8);
                hiddenSolutionArray[i] = temp;
            }
        }

        // Generates the solution for hard mode
        // Random numbers that ranges from 1 to 10 is placed in the solution array
        public void generateHardSolution()
        {
            int temp;
            for (int i = 0; i < hiddenSolutionArray.Length; i++)
            {
                temp = rng.Next(0, 10);
                hiddenSolutionArray[i] = temp;
            }
        }

        // Function that generates the hints for the player after they have made their guess
        // This is the black and white pins the user gets to see.
        // This is done by comparing the solution array with the guess array
        // By seeing if they are the right numbers in the array along with the position in the array
        public void generateHint(int[] guess, int[] solution)
        {
            int[] hiddenHintArray = new int[4];
            int[] newGuess = new int[4];
            int[] newSolution = new int[4];
            int counter = 0;
            for (int a = 0; a < hiddenHintArray.Length; a++)
            {
                newGuess[a] = guess[a];
                newSolution[a] = solution[a];
            }
            for (int i = 0; i < hiddenHintArray.Length; i++)
            {
                if (newGuess[i] != -1 && newSolution[i] != -1 && newGuess[i] == newSolution[i])
                {
                    newGuess[i] = -1;
                    newSolution[i] = -1;
                    hiddenHintArray[counter] = 2;
                    counter++;
                }
            }
            for (int j = 0; j < hiddenHintArray.Length; j++)
            {
                for (int k = 0; k < hiddenHintArray.Length; k++)
                {
                    if (newGuess[k] != -1 && newSolution[j] != -1 && newGuess[k] == newSolution[j])
                    {
                        newGuess[k] = -1;
                        newSolution[j] = -1;
                        hiddenHintArray[counter] = 1;
                        counter++;
                    }
                }
            }
            hints.setHint(hiddenHintArray);
        }

        // Function that checks the guess array and the solution array
        // By comparing the two if they match, we have a winner.
        public bool checkWin()
        {
            for (int i = 0; i < guess.returnGuessArray().Length; i++)
            {
                if (guess.returnGuessArray().SequenceEqual(hiddenSolutionArray))
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        // Function that counts the number of rounds.
        // It also determines if the round is a winning round.
        public bool processRound(int[] solution)
        {
            generateHint(guess.returnGuessArray(), solution);
            if (checkWin())
            {
                win = true;
                return true;
            }
            else
            {
                attempt++;
                return false;
            }
        }

        // Function that resets the number attempts back to 0
        public void resetAttempts()
        {
            attempt = 0;
        }

        // Function that returns the number of attemps
        public int returnAttempts()
        {
            return attempt;
        }

        // Function that returns the boolean win
        public bool returnWin()
        {
            return win;
        }
    }
}
