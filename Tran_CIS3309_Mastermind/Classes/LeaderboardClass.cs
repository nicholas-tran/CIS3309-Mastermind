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
    // The leaderboard class is in control of the leaderboard
    // It takes the name of the winner and writes it to the leaderboard text file
    // It also sorts the leaderboard based on difficulty, turns, and time
    class LeaderboardClass
    {
        //Attributes
        List<Player> easy = new List<Player>();
        List<Player> medium = new List<Player>();
        List<Player> hard = new List<Player>();
        private static string LeaderboardFilePath = "leaderboard.txt";

        // Method that reads from the leaderboard text file
        // and stores the text from the file into array of strings
        public Boolean initializeEntireList()
        {
            currentFileClass currentLeaderboardFile = new currentFileClass(LeaderboardFilePath);
            string nextRecord;
            Boolean isEndOfFile = true;
            int countProcessedRecords = 0;
            Player newPlayer;

            nextRecord = currentLeaderboardFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                if (nextRecord == null)
                {
                    break;
                }
                String[] stringArray = new String[4];
                nextRecord.Trim(' ');
                stringArray = nextRecord.Split('*');
                for (int i = 0; i < stringArray.Length; i++)
                {
                    string newString = stringArray[i];
                    newString = newString.Trim(' ');
                    stringArray[i] = newString;

                }
                newPlayer = new Player(stringArray[0], stringArray[1], Convert.ToInt32(stringArray[2]), Convert.ToInt32(stringArray[3]));
                countProcessedRecords++;
                if (newPlayer.getDifficulty().Equals("Easy"))
                {
                    easy.Add(newPlayer);
                }
                if (newPlayer.getDifficulty().Equals("Medium"))
                {
                    medium.Add(newPlayer);
                }
                if (newPlayer.getDifficulty().Equals("Hard"))
                {
                    hard.Add(newPlayer);
                }
                nextRecord = currentLeaderboardFile.getNextRecord(ref isEndOfFile);
            } //end While
            currentLeaderboardFile.closeFile();
            if (countProcessedRecords > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  // end initializeEntireList

        // Function that returns the player list for easy mode
        public List<Player> returnEasyList()
        {
            return easy;
        }

        // Function that returns the player list for medium mode
        public List<Player> returnMediumList()
        {
            return medium;
        }

        // Function that returns the player list for hard mode
        public List<Player> returnHardList()
        {
            return hard;
        }


        // Function that adds the winner to the leaderboard
        // Player is added to the leader board by difficulty
        // Then it is sorted by the number of turns
        // Then by the amount of time left
        // Finally the the 11th element is removed so top 10 is shown 
        public void addLeaderboard(string name, string difficulty, int turn, int time)
        {
            Player newPlayer = new Player(difficulty, name, turn, time);
            if (difficulty.Equals("Easy"))
            {
                easy.Add(newPlayer);
                easy = easy.OrderBy(p => p.getTurn()).ThenBy(p => p.getTime()).ToList();
                easy.RemoveAt(10);
            }
            if (difficulty.Equals("Medium"))
            {
                medium.Add(newPlayer);
                medium = medium.OrderBy(p => p.getTurn()).ThenBy(p => p.getTime()).ToList();
                medium.RemoveAt(10);

            }
            if (difficulty.Equals("Hard"))
            {
                hard.Add(newPlayer);
                hard = hard.OrderBy(p => p.getTurn()).ThenBy(p => p.getTime()).ToList();
                hard.RemoveAt(10);

            }
        }

        // Function that writes to the leaderboard text file
        public void writeLeaderboard()
        {
            updatedFileClass updatedLeaderboardFile = new updatedFileClass(LeaderboardFilePath);
            for (int i = 0; i<10; i++)
            {
                updatedLeaderboardFile.writeNextRecord(easy.ElementAt(i).returnInfo());
                updatedLeaderboardFile.writeNextRecord(hard.ElementAt(i).returnInfo());
                updatedLeaderboardFile.writeNextRecord(medium.ElementAt(i).returnInfo());
            }
            updatedLeaderboardFile.closeFile();
        }
    }
}
