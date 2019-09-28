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
    // The player class holds all the information needed for the player to be written to the leaderboard
    // It also has getters and setters for the attributes for the player
    class Player
    {
        // Attributes
        String hiddenName = "";
        String hiddenDifficulty = "";
        int hiddenTurns = 0;
        int hiddenTime = 0;

        // Paramaterized constructor
        public Player(String difficulty, String name, int turns, int time)
        {
            hiddenDifficulty = difficulty;
            hiddenName = name;
            hiddenTurns = turns;
            hiddenTime = time;
        }

        // Function that returns hidden difficulty
        public string getDifficulty()
        {
            return this.hiddenDifficulty;
        }

        // Returns that returns hidden name
        public string getName()
        {
            return this.hiddenName;
        }

        // Function that returns hidden turn
        public int getTurn()
        {
            return this.hiddenTurns;
        }

        // Function that returns hidden time
        public int getTime()
        {
            return this.hiddenTime;
        }

        // Function that sets hidden name
        public void setName(string name)
        {
            this.hiddenName = name;
        }

        // Function that sets hidden name
        public void setTime(int time)
        {
            this.hiddenTime = time;
        }

        // Function that sets hidden turn
        public void setTurn(int turn)
        {
            this.hiddenTurns = turn;
        }

        // Function that returns difficulty, namme, turns, and time in a string
        public string returnInfo()
        {
            string temp = hiddenDifficulty + " * " + hiddenName + " * " + hiddenTurns + " * " + hiddenTime;
            return temp;
        }
    }
}
